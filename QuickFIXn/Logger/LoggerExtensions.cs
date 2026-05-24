using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

// FP Enhancement: 2026-05-24 — typed call sites for the FixPortal log events. Callers say `Log.OnRejectionEvent(...)` / `Log.OnIncomingAndOutgoing(...)` and the extension packs the args into the structured state record dispatched via MEL's EventId machinery.
public static class LoggerExtensions
{
    public static void OnRejectionEvent(this ILogger logger, string originalMessage, string rejectionText)
    {
        var state = new RejectionEventState(originalMessage, rejectionText);
        logger.Log(LogLevel.Warning, LogEventIds.RejectionEvent, state, null,
            (s, _) => s.ToString());
    }

    public static void OnIncomingAndOutgoing(this ILogger logger,
        (int Id, string Raw, string Xml, string Json) message)
    {
        var state = new IncomingAndOutgoingState(message.Id, message.Raw, message.Xml, message.Json);
        logger.Log(LogLevel.Information, LogEventIds.IncomingAndOutgoing, state, null,
            (s, _) => s.ToString());
    }
}
