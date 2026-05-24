using System;

namespace QuickFix.Logger;

/// <summary>
/// Session log for messages and events
/// </summary>
public interface ILog : IDisposable
{
    /// <summary>
    /// Clears the log and removes any persistent log data
    /// </summary>
    void Clear();

    /// <summary>
    /// Logs an incoming message
    /// </summary>
    /// <param name="msg">a raw FIX message</param>
    void OnIncoming(string msg);

    /// <summary>
    /// Logs an outgoing message
    /// </summary>
    /// <param name="msg">a raw FIX message</param>
    void OnOutgoing(string msg);

    /// <summary>
    /// Logs a session event
    /// </summary>
    /// <param name="s">event description</param>
    void OnEvent(string s);

    // FP Enhancement: 2026-05-24 — extended ILog surface for the FixPortal logging extensions:
    //   OnRejectionEvent — structured rejection event paired with the original wire message.
    //   LogOn / LogOff — explicit logon/logoff markers for sinks that want session-life events.
    //   OnIncomingAndOutgoing — tracked-message tuple (LogId + Raw + Xml + Json) emitted via Session.LogExtended.
    // Implementors default these to no-ops where the underlying sink doesn't care.
    void OnRejectionEvent(string originalMessage, string eventText);
    void LogOn();
    void LogOff();
    void OnIncomingAndOutgoing((int Id, string Raw, string Xml, string Json) message);
}