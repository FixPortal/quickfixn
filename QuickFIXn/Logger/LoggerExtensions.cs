using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

// FixPortal Enhancement - extension methods for CP-specific logging via ILogger
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
