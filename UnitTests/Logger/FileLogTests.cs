using System;
using System.IO;
using NUnit.Framework;
using QuickFix.Logger;

namespace UnitTests.Logger;

[TestFixture]
public class FileLogTests
{
    private FileLog? _log;

    private readonly QuickFix.SessionID _defaultSessionId = new ("FIX.4.2", "SENDERCOMP", "TARGETCOMP");
    private readonly string _logDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "log");
    private readonly string _eventLogFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "log",
        "FIX.4.2-SENDERCOMP-TARGETCOMP.event.current.log");
    private readonly string _messagesLogFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "log",
            "FIX.4.2-SENDERCOMP-TARGETCOMP.messages.current.log");

    [SetUp]
    public void Setup()
    { }

    [TearDown]
    public void Teardown()
    {
        _log?.Dispose();
        _log = null;
    }

    [Test]
    public void TestPrefix()
    {
        QuickFix.SessionID someSessionId = new QuickFix.SessionID("FIX.4.4", "sender", "target");
        QuickFix.SessionID someSessionIdWithQualifier = new QuickFix.SessionID("FIX.4.3", "sender", "target", "foo");

        Assert.That(FileLog.Prefix(someSessionId), Is.EqualTo("FIX.4.4-sender-target"));
        Assert.That(FileLog.Prefix(someSessionIdWithQualifier), Is.EqualTo("FIX.4.3-sender-target-foo"));
    }

    [Test]
    public void TestPrefixForSubsAndLocation()
    {
        QuickFix.SessionID sessionIdWithSubsAndLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "SENDERLOC", "TARGETCOMP", "TARGETSUB", "TARGETLOC");
        Assert.That(FileLog.Prefix(sessionIdWithSubsAndLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB_SENDERLOC-TARGETCOMP_TARGETSUB_TARGETLOC"));

        QuickFix.SessionID sessionIdWithSubsNoLocation = new QuickFix.SessionID("FIX.4.2", "SENDERCOMP", "SENDERSUB", "TARGETCOMP", "TARGETSUB");
        Assert.That(FileLog.Prefix(sessionIdWithSubsNoLocation), Is.EqualTo("FIX.4.2-SENDERCOMP_SENDERSUB-TARGETCOMP_TARGETSUB"));
    }

    private FileLogFactory CreateTestFactory()
    {
        if (Directory.Exists(_logDirectory))
            Directory.Delete(_logDirectory, true);

        QuickFix.SessionSettings settings = new QuickFix.SessionSettings();
        QuickFix.SettingsDictionary config = new QuickFix.SettingsDictionary();
        config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
        config.SetString(QuickFix.SessionSettings.FILE_LOG_PATH, _logDirectory);

        settings.Set(_defaultSessionId, config);
        return new FileLogFactory(settings);
    }

    [Test]
    public void TestGeneratedFileName()
    {
        FileLogFactory factory = CreateTestFactory();
        _log = (FileLog)factory.Create(_defaultSessionId);

        // Log files aren't created before first log statement
        Assert.That(!File.Exists(_eventLogFilePath));
        Assert.That(!File.Exists(_messagesLogFilePath));

        _log.OnEvent("some event");

        // The event file exists now
        Assert.That(File.Exists(_eventLogFilePath));
        Assert.That(!File.Exists(_messagesLogFilePath));

        _log.OnIncoming("some incoming");
        _log.OnOutgoing("some outgoing");

        // The message file exists now
        Assert.That(File.Exists(_eventLogFilePath));
        Assert.That(File.Exists(_messagesLogFilePath));

        // cleanup (don't delete log unless success)
        _log.Dispose();
        _log = null;
        Directory.Delete(_logDirectory, true);
    }

    [Test]
    public void TestThrowsIfNoConfig()
    {
        QuickFix.SettingsDictionary config = new QuickFix.SettingsDictionary();
        config.SetString(QuickFix.SessionSettings.CONNECTION_TYPE, "initiator");
        QuickFix.SessionSettings settings = new QuickFix.SessionSettings();
        settings.Set(_defaultSessionId, config);

        FileLogFactory factory = new FileLogFactory(settings);
        var ex = Assert.Throws<QuickFix.ConfigError>(delegate { factory.Create(_defaultSessionId); });
        Assert.That(ex!.Message, Does.Contain("Configuration failed: No value for key: FileLogPath"));
    }

    [Test]
    public void TestClear()
    {
        FileLogFactory factory = CreateTestFactory();
        _log = (FileLog)factory.Create(_defaultSessionId);

        _log.OnEvent("some event");
        _log.OnIncoming("some incoming");

        // Clear() should delete the contents of the log files...
        _log.Clear();
        Assert.That(new FileInfo(_eventLogFilePath).Length, Is.EqualTo(0));
        Assert.That(new FileInfo(_messagesLogFilePath).Length, Is.EqualTo(0));

        // ... and leave them ready for more logging
        Assert.DoesNotThrow(delegate { _log.OnEvent("another event after clear"); });
        Assert.DoesNotThrow(delegate { _log.OnIncoming("another incoming after clear"); });

        // cleanup (don't delete log unless success)
        _log.Dispose();
        _log = null;
        Directory.Delete(_logDirectory, true);
    }

    [Test]
    public void TestDateRotation_WritesToNewDirectoryAfterDayChange()
    {
        // Regression: previously the constructor stored the already-resolved path in _fileLogPath, so the
        // day-rotation flow (DirectoryCheck -> EvaluateCandidateLog) could never re-substitute {DATE:...}.
        // A long-running session would write day 1, 2, 3, ... into the day-1 directory forever.

        string rootDir = Path.Combine(TestContext.CurrentContext.TestDirectory, "log-rotation-test");
        if (Directory.Exists(rootDir))
            Directory.Delete(rootDir, true);

        try
        {
            var fakeClock = new FakeTimeProvider(new DateTimeOffset(2026, 1, 1, 10, 0, 0, TimeSpan.Zero));
            string template = Path.Combine(rootDir, "{DATE:yyyyMMdd}");

            string day1Dir = Path.Combine(rootDir, "20260101");
            string day1EventFile = Path.Combine(day1Dir, "FIX.4.2-SENDERCOMP-TARGETCOMP.event.current.log");
            string day2Dir = Path.Combine(rootDir, "20260102");
            string day2EventFile = Path.Combine(day2Dir, "FIX.4.2-SENDERCOMP-TARGETCOMP.event.current.log");
            string day2MessagesFile = Path.Combine(day2Dir, "FIX.4.2-SENDERCOMP-TARGETCOMP.messages.current.log");

            FileLog log = new FileLog(template, _defaultSessionId, fakeClock);
            try
            {
                log.OnEvent("first day event");
                Assert.That(File.Exists(day1EventFile), "Day 1 event file should exist after the first write");

                // Advance the clock past midnight into day 2.
                fakeClock.Now = new DateTimeOffset(2026, 1, 2, 9, 0, 0, TimeSpan.Zero);

                log.OnEvent("second day event");
                log.OnIncoming("second day incoming");

                Assert.That(File.Exists(day2EventFile), "Day 2 event file should exist after the day-change write");
                Assert.That(File.Exists(day2MessagesFile), "Day 2 messages file should exist after the day-change write");
                Assert.That(File.Exists(day1EventFile), "Day 1 event file should be preserved across rotation");
            }
            finally
            {
                // Dispose the log so the StreamWriters release the files before we read them.
                log.Dispose();
            }

            // Day 2's event file should have the day-2 content, NOT the day-1 content.
            string day2Content = File.ReadAllText(day2EventFile);
            Assert.That(day2Content, Does.Contain("second day event"));
            Assert.That(day2Content, Does.Not.Contain("first day event"));

            // Day 1's event file should retain its day-1 content untouched by the rotation.
            string day1Content = File.ReadAllText(day1EventFile);
            Assert.That(day1Content, Does.Contain("first day event"));
            Assert.That(day1Content, Does.Not.Contain("second day event"));
        }
        finally
        {
            if (Directory.Exists(rootDir))
                Directory.Delete(rootDir, true);
        }
    }

    /// <summary>
    /// Minimal <see cref="TimeProvider"/> stub for tests that need to simulate a day change without bringing in
    /// the full Microsoft.Extensions.TimeProvider.Testing package.
    /// </summary>
    private sealed class FakeTimeProvider : TimeProvider
    {
        public DateTimeOffset Now { get; set; }

        public FakeTimeProvider(DateTimeOffset initial) => Now = initial;

        public override DateTimeOffset GetUtcNow() => Now.ToUniversalTime();
        public override TimeZoneInfo LocalTimeZone => TimeZoneInfo.Utc;
    }
}
