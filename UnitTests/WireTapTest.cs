using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using QuickFix.Logger;
using QuickFix.Store;

namespace UnitTests;

/// <summary>
/// FP enhancement: tests for the <see cref="IFixWireTap"/> verbatim wire-frame capture seam.
/// The tap must fire once per inbound arrival (pre-parse, pre-redaction) and for every outbound
/// frame (pre-redaction), and a null or throwing tap must never disrupt FIX processing.
/// </summary>
[TestFixture]
public class WireTapTest
{
    private sealed class RecordingWireTap : IFixWireTap
    {
        public List<string> Inbound { get; } = new();
        public List<string> Outbound { get; } = new();

        public void OnInbound(SessionID sessionId, string rawFrame) => Inbound.Add(rawFrame);
        public void OnOutbound(SessionID sessionId, string rawFrame) => Outbound.Add(rawFrame);
    }

    private sealed class ThrowingWireTap : IFixWireTap
    {
        public void OnInbound(SessionID sessionId, string rawFrame) => throw new InvalidOperationException("boom");
        public void OnOutbound(SessionID sessionId, string rawFrame) => throw new InvalidOperationException("boom");
    }

    private SessionTestSupport.MockResponder _responder = new();
    private SessionTestSupport.MockApplication _application = new();
    private SessionID _sessionId = new("FIX.4.2", "SENDER", "TARGET");
    private SeqNumType _seqNum = 1;

    private Session BuildAcceptor(IFixWireTap? tap)
    {
        _responder = new SessionTestSupport.MockResponder();
        _application = new SessionTestSupport.MockApplication();
        _sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        _seqNum = 1;

        SettingsDictionary config = new();
        config.SetBool(SessionSettings.PERSIST_MESSAGES, false);
        config.SetString(SessionSettings.CONNECTION_TYPE, "acceptor");
        config.SetString(SessionSettings.START_TIME, "00:00:00");
        config.SetString(SessionSettings.END_TIME, "00:00:00");

        var logFactory = new LogFactoryAdapter(new NullLogFactory());

        var session = new Session(
            false, _application, new MemoryStoreFactory(), _sessionId,
            new DataDictionaryProvider(), new SessionSchedule(config), 0,
            logFactory, new DefaultMessageFactory(), "blah", tap);
        session.SetResponder(_responder);
        session.CheckLatency = false;
        return session;
    }

    private string SendLogonTo(Session session)
    {
        var msg = new QuickFix.FIX42.Logon();
        msg.Header.SetField(new TargetCompID(_sessionId.SenderCompID));
        msg.Header.SetField(new SenderCompID(_sessionId.TargetCompID));
        msg.Header.SetField(new MsgSeqNum(_seqNum++));
        msg.Header.SetField(new SendingTime(DateTime.UtcNow));
        msg.SetField(new HeartBtInt(1));
        string raw = msg.ConstructString();
        session.Next(raw);
        return raw;
    }

    [Test]
    public void Inbound_tap_fires_once_per_arrival_with_verbatim_frame()
    {
        var tap = new RecordingWireTap();
        var session = BuildAcceptor(tap);

        string raw = SendLogonTo(session);

        Assert.That(tap.Inbound, Has.Count.EqualTo(1));
        Assert.That(tap.Inbound[0], Is.EqualTo(raw));
    }

    [Test]
    public void Outbound_tap_captures_every_sent_frame_verbatim()
    {
        var tap = new RecordingWireTap();
        var session = BuildAcceptor(tap);

        SendLogonTo(session);

        // The acceptor answers the logon, so at least one outbound frame is tapped, verbatim FIX
        // (SOH-delimited, with the logon MsgType present).
        Assert.That(tap.Outbound, Is.Not.Empty);
        Assert.That(tap.Outbound[0], Does.Contain("35=A"));
    }
    [Test]
    public void Outbound_tap_fires_when_responder_is_null()
    {
        // A-F5: the capture seam must record every generated outbound frame, not only those that
        // reach the wire. When the responder is null (session disconnecting), Send returns false
        // and the frame is not transmitted — but the tap must still fire so the correlator sees
        // the attempted outbound and can mark it as un-transmitted rather than missing.
        var tap = new RecordingWireTap();
        _application = new SessionTestSupport.MockApplication();
        _sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        SettingsDictionary config = new();
        config.SetBool(SessionSettings.PERSIST_MESSAGES, false);
        config.SetString(SessionSettings.CONNECTION_TYPE, "acceptor");
        config.SetString(SessionSettings.START_TIME, "00:00:00");
        config.SetString(SessionSettings.END_TIME, "00:00:00");
        var session = new Session(
            false, _application, new MemoryStoreFactory(), _sessionId,
            new DataDictionaryProvider(), new SessionSchedule(config), 0,
            new LogFactoryAdapter(new NullLogFactory()), new DefaultMessageFactory(), "blah", tap);
        // deliberate: no SetResponder call — _responder remains null
        var result = session.Send("8=FIX.4.235=049=SENDER56=TARGET34=152=20260611-00:00:0010=000");
        Assert.That(result, Is.False, "Send must return false when responder is null");
        Assert.That(tap.Outbound, Has.Count.EqualTo(1), "tap must fire even though the frame was not transmitted");
    }

    [Test]
    public void Inbound_tap_captures_unredacted_frame()
    {
        var tap = new RecordingWireTap();
        var session = BuildAcceptor(tap);
        // Redaction is log-only and happens after the tap point, so the captured raw is always the
        // original. Redact the HeartBtInt tag (108) to prove the tap sidesteps the redaction path.
        session.RedactFieldsInLogs = [Tags.HeartBtInt];

        SendLogonTo(session);

        Assert.That(tap.Inbound[0], Does.Contain("108=1"));
        Assert.That(tap.Inbound[0], Does.Not.Contain("redacted"));
    }

    private QuickFix.FIX42.NewOrderSingle CreateNos(SeqNumType n)
    {
        var order = new QuickFix.FIX42.NewOrderSingle(
            new ClOrdID("1"), new HandlInst(HandlInst.MANUAL_ORDER), new Symbol("IBM"),
            new Side(Side.BUY), new TransactTime(), new OrdType(OrdType.LIMIT));
        order.Header.SetField(new TargetCompID(_sessionId.SenderCompID));
        order.Header.SetField(new SenderCompID(_sessionId.TargetCompID));
        order.Header.SetField(new SendingTime(DateTime.UtcNow));
        order.Header.SetField(new MsgSeqNum(n));
        return order;
    }

    [Test]
    public void Inbound_tap_fires_on_queued_replay_to_enable_correlator_slotting()
    {
        // A-F1: when a frame is queued (sequence gap) and later replayed via NextQueued, the
        // capture correlator has no pending CaptureId unless the tap fires again on replay.
        // NextQueued now calls TapInbound before NextMessage so the correlator can slot a fresh
        // id for the replayed frame — four taps in total: logon arrival, nos3 arrival, nos2
        // arrival, and the nos3 replay.
        var tap = new RecordingWireTap();
        var session = BuildAcceptor(tap);
        SendLogonTo(session); // seq 1 establishes the session

        // Arrive seq 3 first (gap) — the session queues it and requests a resend.
        string nos3 = CreateNos(3).ConstructString();
        session.Next(nos3);
        // Arrive the missing seq 2 — the session processes it, then replays the queued seq 3.
        string nos2 = CreateNos(2).ConstructString();
        session.Next(nos2);

        // Four taps: three wire arrivals plus one replay tap for the queued seq-3 frame.
        Assert.That(tap.Inbound, Has.Count.EqualTo(4));
        Assert.That(tap.Inbound.FindAll(f => f == nos3), Has.Count.EqualTo(2));
    }

    [Test]
    public void SessionFactory_threads_wiretap_into_created_session()
    {
        // The acceptor/initiator only ever build a Session via SessionFactory, so the tap must
        // ride through the factory ctor onto the Session it creates — otherwise the seam wired at
        // Session level is unreachable in production.
        var tap = new RecordingWireTap();
        _application = new SessionTestSupport.MockApplication();
        _responder = new SessionTestSupport.MockResponder();
        _sessionId = new SessionID("FIX.4.2", "SENDER", "TARGET");
        _seqNum = 1;

        SettingsDictionary config = new();
        config.SetBool(SessionSettings.USE_DATA_DICTIONARY, false);
        config.SetString(SessionSettings.CONNECTION_TYPE, "acceptor");
        config.SetString(SessionSettings.START_TIME, "00:00:00");
        config.SetString(SessionSettings.END_TIME, "00:00:00");
        config.SetBool(SessionSettings.PERSIST_MESSAGES, false);

        var factory = new SessionFactory(_application, new MemoryStoreFactory(), null, null, tap);
        var session = factory.Create(_sessionId, config);
        session.SetResponder(_responder);
        session.CheckLatency = false;

        string raw = SendLogonTo(session);

        Assert.That(tap.Inbound, Has.Count.EqualTo(1));
        Assert.That(tap.Inbound[0], Is.EqualTo(raw));
    }

    [Test]
    public void Null_wiretap_processes_logon_normally()
    {
        var session = BuildAcceptor(null);

        Assert.DoesNotThrow(() => SendLogonTo(session));
        Assert.That(_responder.GetCount(MsgType.LOGON), Is.GreaterThanOrEqualTo(1));
    }

    [Test]
    public void Throwing_wiretap_does_not_disrupt_processing()
    {
        var session = BuildAcceptor(new ThrowingWireTap());

        Assert.DoesNotThrow(() => SendLogonTo(session));
        Assert.That(_responder.GetCount(MsgType.LOGON), Is.GreaterThanOrEqualTo(1));
    }
}
