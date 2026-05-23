
using System;

namespace QuickFix.Logger;

/// <summary>
/// Log implementation that does not do anything
/// </summary>
public sealed class NullLog : ILog
{
    #region ILog Members

    public void Clear()
    { }

    public void OnIncoming(string msg)
    { }

    public void OnOutgoing(string msg)
    { }

    public void OnEvent(string s)
    { }

    public void Dispose()
    { }

    #endregion

    #region CP Enhancement

    public void LogOn() { }
    public void LogOff() { }
    public void OnIncomingAndOutgoing((int Id, string Raw, string Xml, string Json) message) { }
    public void OnRejectionEvent(string originalMessage, string rejectionText) { }

    #endregion
}