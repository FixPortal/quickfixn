using System;
using Microsoft.Extensions.Logging;

namespace QuickFix.Logger;

/// <summary>
/// Wraps the legacy (pre-v1.14) ILog interface so that it can
/// be used as an ILogger.
/// </summary>
internal class LogAdapter : ILogger, IDisposable
{
    private readonly ILog _log;

    public LogAdapter(ILog log)
    {
        _log = log;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
        if (!IsEnabled(logLevel)) return;
        if (eventId == LogEventIds.IncomingMessage)
        {
            _log.OnIncoming(formatter(state, exception));
        }
        else if (eventId == LogEventIds.OutgoingMessage)
        {
            _log.OnOutgoing(formatter(state, exception));
        }
        // FixPortal Enhancement
        else if (eventId == LogEventIds.RejectionEvent && state is RejectionEventState rejection)
        {
            _log.OnRejectionEvent(rejection.OriginalMessage, rejection.RejectionText);
        }
        else if (eventId == LogEventIds.IncomingAndOutgoing && state is IncomingAndOutgoingState iao)
        {
            _log.OnIncomingAndOutgoing((iao.Id, iao.Raw, iao.Xml, iao.Json));
        }
        else
        {
            _log.OnEvent(formatter(state, exception));
        }
    }

    public bool IsEnabled(LogLevel logLevel) => logLevel != LogLevel.None;

    public IDisposable BeginScope<TState>(TState state) where TState : notnull => default!;

    public void Dispose()
    {
        _log.Dispose();
    }
}

// FixPortal Enhancement - structured state types for CP log events
public record RejectionEventState(string OriginalMessage, string RejectionText)
{
    public override string ToString() => RejectionText;
}

public record IncomingAndOutgoingState(int Id, string Raw, string Xml, string Json)
{
    public override string ToString() => Raw;
}
