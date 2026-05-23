using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

public static class LogEventIds
{
    public static readonly EventId IncomingMessage = new(7702, "IncomingMessage");
    public static readonly EventId OutgoingMessage = new(7703, "OutgoingMessage");

    // FixPortal Enhancement
    public static readonly EventId RejectionEvent = new(7710, "RejectionEvent");
    public static readonly EventId IncomingAndOutgoing = new(7711, "IncomingAndOutgoing");
}
