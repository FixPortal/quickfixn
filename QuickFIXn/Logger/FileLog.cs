using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using QuickFix.Fields.Converters;
using QuickFix.ObjectPooling;
using QuickFix.Util;

namespace QuickFix.Logger;

/// <summary>
/// File log implementation
/// </summary>
public class FileLog : ILog
{
    private readonly object _sync = new();

    private System.IO.StreamWriter? _messageLog;
    private System.IO.StreamWriter? _eventLog;

    // FP Enhancement: 2026-05-24 — keep the parsed log root + the day-rotated current message/event filenames so DirectoryCheck() can re-roll the log files when the date changes (see InitialiseLogs / DirectoryCheck below).
    private readonly string _fileLogPath;
    private string _messageLogFileName;
    private string _eventLogFileName;



    /// <summary>
    ///
    /// </summary>
    /// <param name="fileLogPath">
    /// All back or forward slashes in this path will be converted as needed to the running platform's preferred
    /// path separator (i.e. "/" will become "\" on windows, else "\" will become "/" on all other platforms)
    /// </param>
    /// <param name="sessionId"></param>
    public FileLog(string fileLogPath, SessionID sessionId)
    {
        // FP Enhancement: 2026-05-24 — defer file creation until first write (InitialiseLogs with initOnly:true) and pre-resolve the parsed path so DirectoryCheck() can date-rotate later.
        _fileLogPath = Enhancements.Utility.ParsePath(StringUtil.FixSlashes(fileLogPath));
        _sessionPrefix = Prefix(sessionId);

        InitialiseLogs(_fileLogPath, true);
    }

    public static string Prefix(SessionID sessionId)
    {
        using PooledStringBuilder pooledSb = new PooledStringBuilder();
        System.Text.StringBuilder prefix = pooledSb.Builder.Append(sessionId.BeginString).Append('-').Append(sessionId.SenderCompID);
        if (SessionID.IsSet(sessionId.SenderSubID))
            prefix.Append('_').Append(sessionId.SenderSubID);
        if (SessionID.IsSet(sessionId.SenderLocationID))
            prefix.Append('_').Append(sessionId.SenderLocationID);
        prefix.Append('-').Append(sessionId.TargetCompID);
        if (SessionID.IsSet(sessionId.TargetSubID))
            prefix.Append('_').Append(sessionId.TargetSubID);
        if (SessionID.IsSet(sessionId.TargetLocationID))
            prefix.Append('_').Append(sessionId.TargetLocationID);

        if (SessionID.IsSet(sessionId.SessionQualifier))
            prefix.Append('-').Append(sessionId.SessionQualifier);

        return prefix.ToString();
    }

    private void DisposedCheck()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
    }

    [MemberNotNull(nameof(_messageLog))]
    private void EnsureMessageLogInit(bool append = true)
    {
        Debug.Assert(Monitor.IsEntered(_sync), "Expected to hold the lock");

        _messageLog ??= new System.IO.StreamWriter(_messageLogFileName, append)
        {
            AutoFlush = true
        };
    }

    [MemberNotNull(nameof(_eventLog))]
    private void EnsureEventLogInit(bool append = true)
    {
        Debug.Assert(Monitor.IsEntered(_sync), "Expected to hold the lock");

        _eventLog ??= new System.IO.StreamWriter(_eventLogFileName, append)
        {
            AutoFlush = true
        };
    }

    #region Log Members

    /// <summary>
    /// Delete log content and leave ready for next log message
    /// </summary>
    public void Clear()
    {
        lock (_sync)
        {
            DisposedCheck();

            _messageLog?.Dispose();
            _eventLog?.Dispose();

            _messageLog = null;
            _eventLog = null;

            EnsureMessageLogInit(append: false);
            EnsureEventLogInit(append: false);
        }
    }

    public void OnIncoming(string msg)
    {
        lock (_sync)
        {
            DisposedCheck();
            DirectoryCheck();
            EnsureMessageLogInit();
            _messageLog.WriteLine(DateTimeConverter.ToFIX(DateTime.UtcNow, TimeStampPrecision.Millisecond) + " : " + msg);
        }
    }

    public void OnOutgoing(string msg)
    {
        lock (_sync)
        {
            DisposedCheck();
            DirectoryCheck();
            EnsureMessageLogInit();
            _messageLog.WriteLine(DateTimeConverter.ToFIX(DateTime.UtcNow, TimeStampPrecision.Millisecond) + " : " + msg);
        }
    }

    public void OnEvent(string s)
    {
        lock (_sync)
        {
            DisposedCheck();
            DirectoryCheck();
            EnsureEventLogInit();
            _eventLog.WriteLine(DateTimeConverter.ToFIX(DateTime.UtcNow, TimeStampPrecision.Millisecond) + " : " + s);
        }
    }

    #endregion

    #region IDisposable Members
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private bool _disposed;
    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
        {
            return;
        }

        lock (_sync)
        {
            if (_disposed)
            {
                return;
            }

            _messageLog?.Dispose();
            _eventLog?.Dispose();

            _disposed = true;
        }
    }
    #endregion

    // FP Enhancement: 2026-05-24 — date-aware log rotation. Each write calls DirectoryCheck() to see if the day has rolled over; if so, EvaluateCandidateLog() re-resolves the log directory (so ParsePath's {DATE:...} token, if present, expands fresh) and reinitialises the streams. The streams themselves are created lazily so a session that never writes leaves no empty files behind.
    private readonly string _sessionPrefix;
    private DateTime _creationDate;
    private string? _currentFileLogPath;
    private void DirectoryCheck()
    {
        if (_creationDate.CompareTo(DateTime.Now.Date) == 0) return;
        EvaluateCandidateLog();
    }
    private void EvaluateCandidateLog()
    {
        var normalizedPath = Enhancements.Utility.ParsePath(StringUtil.FixSlashes(_fileLogPath));

        if (normalizedPath != _currentFileLogPath)
        {
            InitialiseLogs(normalizedPath, false);
        }
    }

    private void InitialiseLogs(string normalizedPath, bool initOnly)
    {
        _creationDate = DateTime.Now.Date;

        if (!System.IO.Directory.Exists(normalizedPath))
            System.IO.Directory.CreateDirectory(normalizedPath);

        _messageLogFileName = System.IO.Path.Combine(normalizedPath, _sessionPrefix + ".messages.current.log");
        _eventLogFileName = System.IO.Path.Combine(normalizedPath, _sessionPrefix + ".event.current.log");

        if (initOnly)
            return;

        _currentFileLogPath = normalizedPath;

        EnsureMessageLogInit();
        EnsureEventLogInit();
    }

    // FP Enhancement: 2026-05-24 — ILog hooks for the extended message-tracking and rejection-notification flows; FileLog routes rejections into the event log and ignores the tracked-message tuple (sinks that care about XML/JSON live elsewhere).
    public void LogOn() { }
    public void LogOff() { }
    public void OnIncomingAndOutgoing((int Id, string Raw, string Xml, string Json) message) { }
    public void OnRejectionEvent(string originalMessage, string rejectionText)
    {
        OnEvent(rejectionText);
    }
}
