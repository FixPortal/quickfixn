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
        // FP Enhancement: 2026-05-24 — bridge the FixPortal structured log events (RejectionEvent, IncomingAndOutgoing) from the MEL ILogger pipeline down to the legacy ILog hooks.
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

// FP Enhancement: 2026-05-24 — structured state records that carry the FixPortal-specific log payloads through MEL's `state` slot, with ToString() falling back to a sensible default so sinks that don't know the type still get a readable line.
public record RejectionEventState(string OriginalMessage, string RejectionText)
{
    public override string ToString() => RejectionText;
}

public record IncomingAndOutgoingState(int Id, string Raw, string Xml, string Json)
{
    public override string ToString() => Raw;
}
