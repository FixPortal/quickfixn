using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

public static class LogEventIds
{
    public static readonly EventId IncomingMessage = new(7702, "IncomingMessage");
    public static readonly EventId OutgoingMessage = new(7703, "OutgoingMessage");

    // FP Enhancement: 2026-05-24 — event-id slots for the FixPortal logging extensions; ids picked to sit just above the upstream IncomingMessage/OutgoingMessage block so structured sinks can demux on EventId.
    public static readonly EventId RejectionEvent = new(7710, "RejectionEvent");
    public static readonly EventId IncomingAndOutgoing = new(7711, "IncomingAndOutgoing");
}
