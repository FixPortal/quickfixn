using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using QuickFix;
using QuickFix.Fields;
using QuickFix.Logger;
using QuickFix.Store;

namespace UnitTests;

// Coverage for the FixPortal structured-logging enhancements that previously had no tests:
//  - LogAdapter bridges the FP MEL log events (RejectionEvent/IncomingAndOutgoing) down to ILog
//    (LogAdapter.cs:31-39 + LoggerExtensions.cs).
//  - GenerateReject carries the offending field value into the structured rejection event
//    (Session.cs:1601-1657).
//  - LogExtended emits OnIncomingAndOutgoing for messages tracked in SessionLogIdentifiers
//    (Session.cs:1726-1735).
// Each session fixture uses a distinct SessionID: QuickFix keys sessions (and the per-SessionID
// SessionLogIdentifiers dictionary) by identity, so shared IDs collide across fixtures.

internal sealed class CapturingLog : ILog
{
    public readonly List<(string Original, string Text)> Rejections = new();
    public readonly List<(int Id, string Raw, string Xml, string Json)> IncomingAndOutgoing = new();
    public readonly List<string> Events = new();

    public void OnRejectionEvent(string originalMessage, string eventText) => Rejections.Add((originalMessage, eventText));
    public void OnIncomingAndOutgoing((int Id, string Raw, string Xml, string Json) message) => IncomingAndOutgoing.Add(message);
    public void OnEvent(string s) => Events.Add(s);
    public void OnIncoming(string msg) { }
    public void OnOutgoing(string msg) { }
    public void LogOn() { }
    public void LogOff() { }
    public void Clear() { }
    public void Dispose() { }
}

internal sealed class CapturingLogFactory : ILogFactory
{
    private readonly ILog _log;
    public CapturingLogFactory(ILog log) => _log = log;
    public ILog Create(SessionID sessionId) => _log;
    public ILog CreateNonSessionLog() => _log;
}

[TestFixture]
public class FixPortalLogAdapterBridgeTest
{
    [Test]
    public void RejectionEvent_IsBridgedToILog_OnRejectionEvent()
    {
        var cap = new CapturingLog();
        ILogger logger = new LogAdapter(cap);

        logger.OnRejectionEvent("8=FIX.4.2|...", "Message 5 Rejected: Value is incorrect (Field=54, Value=ZZ)");

        Assert.That(cap.Rejections, Has.Count.EqualTo(1));
        Assert.That(cap.Rejections[0].Original, Is.EqualTo("8=FIX.4.2|..."));
        Assert.That(cap.Rejections[0].Text, Does.Contain("Value=ZZ"));
        Assert.That(cap.Events, Is.Empty, "a bridged rejection event must not also fall through to OnEvent");
    }

    [Test]
    public void IncomingAndOutgoing_IsBridgedToILog_WithPayloadIntact()
    {
        var cap = new CapturingLog();
        ILogger logger = new LogAdapter(cap);

        logger.OnIncomingAndOutgoing((42, "RAW", "<x/>", "{}"));

        Assert.That(cap.IncomingAndOutgoing, Has.Count.EqualTo(1));
        Assert.That(cap.IncomingAndOutgoing[0], Is.EqualTo((42, "RAW", "<x/>", "{}")));
    }
}

[TestFixture]
public class FixPortalRejectValueCarrierTest
{
    private static SettingsDictionary AcceptorConfig()
    {
        var config = new SettingsDictionary();
        config.SetBool(SessionSettings.PERSIST_MESSAGES, false);
        config.SetString(SessionSettings.CONNECTION_TYPE, "acceptor");
        config.SetString(SessionSettings.START_TIME, "00:00:00");
        config.SetString(SessionSettings.END_TIME, "00:00:00");
        return config;
    }

    [Test]
    public void GenerateReject_WithFieldValue_CarriesValueIntoStructuredRejectionEvent()
    {
        var cap = new CapturingLog();
        var sessionId = new SessionID("FIX.4.2", "RV_SENDER", "RV_TARGET");

        using var session = new Session(false, new SessionTestSupport.MockApplication(),
            new MemoryStoreFactory(), sessionId, new DataDictionaryProvider(),
            new SessionSchedule(AcceptorConfig()), 0,
            new LogFactoryAdapter(new CapturingLogFactory(cap)),
            new DefaultMessageFactory(), "blah");

        // GenerateReject sends the reject, so the session must be logged on first.
        session.SetResponder(new SessionTestSupport.MockResponder());
        session.CheckLatency = false;
        var logon = new QuickFix.FIX42.Logon();
        logon.Header.SetField(new TargetCompID(sessionId.SenderCompID));
        logon.Header.SetField(new SenderCompID(sessionId.TargetCompID));
        logon.Header.SetField(new MsgSeqNum(1));
        logon.Header.SetField(new SendingTime(System.DateTime.UtcNow));
        logon.SetField(new HeartBtInt(1));
        session.Next(logon.ConstructString());

        var offending = new Message();
        offending.Header.SetField(new MsgType("D"));
        offending.Header.SetField(new SenderCompID(sessionId.TargetCompID));
        offending.Header.SetField(new TargetCompID(sessionId.SenderCompID));
        offending.Header.SetField(new MsgSeqNum(5));

        session.GenerateReject(offending, QuickFix.FixValues.SessionRejectReason.VALUE_IS_INCORRECT, 54, "ZZ");

        Assert.That(cap.Rejections, Is.Not.Empty, "a value-bearing reject should emit a structured rejection event");
        Assert.That(cap.Rejections[^1].Text, Does.Contain("Field=54"));
        Assert.That(cap.Rejections[^1].Text, Does.Contain("Value=ZZ"));
    }

    [Test]
    public void GenerateReject_RedactsSensitiveFieldsInTheOriginalFrame()
    {
        // Regression for the redaction-leak finding: OnRejectionEvent must not write the
        // verbatim (pre-redaction) original wire frame into the event log.
        var cap = new CapturingLog();
        var sessionId = new SessionID("FIX.4.2", "RD_SENDER", "RD_TARGET");

        using var session = new Session(false, new SessionTestSupport.MockApplication(),
            new MemoryStoreFactory(), sessionId, new DataDictionaryProvider(),
            new SessionSchedule(AcceptorConfig()), 0,
            new LogFactoryAdapter(new CapturingLogFactory(cap)),
            new DefaultMessageFactory(), "blah");
        session.RedactFieldsInLogs = new[] { 554 }; // redact Password(554)
        session.SetResponder(new SessionTestSupport.MockResponder());
        session.CheckLatency = false;

        var logon = new QuickFix.FIX42.Logon();
        logon.Header.SetField(new TargetCompID(sessionId.SenderCompID));
        logon.Header.SetField(new SenderCompID(sessionId.TargetCompID));
        logon.Header.SetField(new MsgSeqNum(1));
        logon.Header.SetField(new SendingTime(System.DateTime.UtcNow));
        logon.SetField(new HeartBtInt(1));
        session.Next(logon.ConstructString());

        // Build a frame carrying a sensitive field, then parse it so RawMessage is populated.
        var built = new Message();
        built.Header.SetField(new MsgType("D"));
        built.Header.SetField(new SenderCompID(sessionId.TargetCompID));
        built.Header.SetField(new TargetCompID(sessionId.SenderCompID));
        built.Header.SetField(new MsgSeqNum(5));
        built.SetField(new StringField(554, "s3cr3t-password"));
        var offending = new Message();
        offending.FromString(built.ConstructString(), validate: false, transportDict: null, appDict: null);
        Assume.That(offending.RawMessage, Does.Contain("s3cr3t-password"));

        session.GenerateReject(offending, QuickFix.FixValues.SessionRejectReason.VALUE_IS_INCORRECT, 554, "x");

        Assert.That(cap.Rejections, Is.Not.Empty);
        Assert.That(cap.Rejections[^1].Original, Does.Not.Contain("s3cr3t-password"),
            "the sensitive field value must not leak into the rejection event log");
        Assert.That(cap.Rejections[^1].Original, Does.Contain("<redacted>"));
    }
}

[TestFixture]
public class FixPortalLogExtendedTest
{
    [Test]
    public void TrackedMessage_EmitsOnIncomingAndOutgoing_WithItsLogId()
    {
        var cap = new CapturingLog();
        var sessionId = new SessionID("FIX.4.2", "LE_SENDER", "LE_TARGET");
        var config = new SettingsDictionary();
        config.SetBool(SessionSettings.PERSIST_MESSAGES, false);
        config.SetString(SessionSettings.CONNECTION_TYPE, "acceptor");
        config.SetString(SessionSettings.START_TIME, "00:00:00");
        config.SetString(SessionSettings.END_TIME, "00:00:00");

        using var session = new Session(false, new SessionTestSupport.MockApplication(),
            new MemoryStoreFactory(), sessionId, new DataDictionaryProvider(),
            new SessionSchedule(config), 0,
            new LogFactoryAdapter(new CapturingLogFactory(cap)),
            new DefaultMessageFactory(), "FIX.4.2");
        session.SetResponder(new SessionTestSupport.MockResponder());
        session.CheckLatency = false;

        var logon = new QuickFix.FIX42.Logon();
        logon.Header.SetField(new TargetCompID(sessionId.SenderCompID));
        logon.Header.SetField(new SenderCompID(sessionId.TargetCompID));
        logon.Header.SetField(new MsgSeqNum(1));
        logon.Header.SetField(new SendingTime(System.DateTime.UtcNow));
        logon.SetField(new HeartBtInt(1));
        session.Next(logon.ConstructString());

        // A non-admin app message at the next expected seqnum.
        var order = new QuickFix.FIX42.NewOrderSingle(
            new ClOrdID("ORD-1"), new HandlInst(HandlInst.MANUAL_ORDER), new Symbol("IBM"),
            new Side(Side.BUY), new TransactTime(), new OrdType(OrdType.MARKET));
        order.Header.SetField(new TargetCompID(sessionId.SenderCompID));
        order.Header.SetField(new SenderCompID(sessionId.TargetCompID));
        order.Header.SetField(new MsgSeqNum(2));
        order.Header.SetField(new SendingTime(System.DateTime.UtcNow));
        var wire = order.ConstructString();

        // Reproduce the session's exact parsed rendering to register the tracking key
        // (LogExtended keys SessionLogIdentifiers on message.ToString()).
        var parsed = new Message(wire, session.SessionDataDictionary, session.ApplicationDataDictionary, false);
        sessionId.SessionLogIdentifiers[parsed.ToString()] = (777, System.DateTime.UtcNow);

        session.Next(wire);

        Assert.That(cap.IncomingAndOutgoing.Exists(x => x.Id == 777), Is.True,
            "a tracked non-admin message should emit OnIncomingAndOutgoing with its LogId");
    }
}

[TestFixture]
public class FixPortalResentTrackerTest
{
    // Pins the A1 fix: the LogExtended resend-correlation cache (_resentTracker) is cleared on a
    // sequence reset, so a recycled seqnum after the reset cannot re-emit the pre-reset LogId.
    [Test]
    public void SequenceReset_ClearsResentTracker_RecycledSeqnumDoesNotReuseStaleLogId()
    {
        var cap = new CapturingLog();
        var sessionId = new SessionID("FIX.4.2", "RT_SENDER", "RT_TARGET");
        var config = new SettingsDictionary();
        config.SetBool(SessionSettings.PERSIST_MESSAGES, false);
        config.SetString(SessionSettings.CONNECTION_TYPE, "acceptor");
        config.SetString(SessionSettings.START_TIME, "00:00:00");
        config.SetString(SessionSettings.END_TIME, "00:00:00");

        using var session = new Session(false, new SessionTestSupport.MockApplication(),
            new MemoryStoreFactory(), sessionId, new DataDictionaryProvider(),
            new SessionSchedule(config), 0,
            new LogFactoryAdapter(new CapturingLogFactory(cap)),
            new DefaultMessageFactory(), "FIX.4.2");
        session.SetResponder(new SessionTestSupport.MockResponder());
        session.CheckLatency = false;

        SendLogon(session, sessionId, seq: 1, reset: false);

        // M1: tracked order at inbound seq 2 -> LogId 10.
        var m1 = BuildOrder(sessionId, seq: 2, clOrdId: "M1");
        Register(session, sessionId, m1, logId: 10);
        session.Next(m1);
        Assume.That(cap.IncomingAndOutgoing.Exists(x => x.Id == 10), Is.True, "M1 should emit LogId 10");

        // Counterparty resets sequence numbers (ResetSeqNumFlag=Y) -> clears _resentTracker.
        SendLogon(session, sessionId, seq: 1, reset: true);

        // M2: a DIFFERENT tracked order at the recycled inbound seq 2 -> LogId 20.
        var m2 = BuildOrder(sessionId, seq: 2, clOrdId: "M2");
        Register(session, sessionId, m2, logId: 20);
        session.Next(m2);

        Assert.That(cap.IncomingAndOutgoing[^1].Id, Is.EqualTo(20),
            "recycled-seqnum message must emit its own LogId, not the pre-reset stale one");
        Assert.That(cap.IncomingAndOutgoing.FindAll(x => x.Id == 10), Has.Count.EqualTo(1),
            "the pre-reset LogId 10 must emit once (for M1), never be re-attributed to M2");
    }

    private static void SendLogon(Session session, SessionID id, ulong seq, bool reset)
    {
        var logon = new QuickFix.FIX42.Logon();
        logon.Header.SetField(new TargetCompID(id.SenderCompID));
        logon.Header.SetField(new SenderCompID(id.TargetCompID));
        logon.Header.SetField(new MsgSeqNum(seq));
        logon.Header.SetField(new SendingTime(System.DateTime.UtcNow));
        logon.SetField(new EncryptMethod(EncryptMethod.NONE));
        logon.SetField(new HeartBtInt(1));
        if (reset)
        {
            logon.SetField(new ResetSeqNumFlag(true));
        }
        session.Next(logon.ConstructString());
    }

    private static string BuildOrder(SessionID id, ulong seq, string clOrdId)
    {
        var o = new QuickFix.FIX42.NewOrderSingle(
            new ClOrdID(clOrdId), new HandlInst(HandlInst.MANUAL_ORDER), new Symbol("IBM"),
            new Side(Side.BUY), new TransactTime(), new OrdType(OrdType.MARKET));
        o.Header.SetField(new TargetCompID(id.SenderCompID));
        o.Header.SetField(new SenderCompID(id.TargetCompID));
        o.Header.SetField(new MsgSeqNum(seq));
        o.Header.SetField(new SendingTime(System.DateTime.UtcNow));
        return o.ConstructString();
    }

    private static void Register(Session session, SessionID id, string wire, int logId)
    {
        var parsed = new Message(wire, session.SessionDataDictionary, session.ApplicationDataDictionary, false);
        id.SessionLogIdentifiers[parsed.ToString()] = (logId, System.DateTime.UtcNow);
    }
}
