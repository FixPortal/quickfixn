using Microsoft.Extensions.Logging;
using QuickFix.Enhancements.DataDictionary;

namespace QuickFix.Logger;

/// <summary>
/// Creates QuickFIX/n-specific ILoggers.
/// Introduced in v1.14 for Microsoft.Extensions.Logging support.
/// </summary>
internal interface IQuickFixLoggerFactory
{
    public ILogger CreateSessionLogger(SessionID sessionId);
    public ILogger CreateNonSessionLogger<T>();

    // FixPortal Enhancement - create logger with DataDictionary version info
    public ILogger CreateSessionLogger(SessionID sessionId, VersionInfo versionInfo)
        => CreateSessionLogger(sessionId); // default implementation falls back to standard
}
