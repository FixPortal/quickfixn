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
