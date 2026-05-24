using System;
using System.IO;
using NUnit.Framework;
using QuickFix.Enhancements;

namespace UnitTests.Enhancements
{
    [TestFixture]
    public class UtilityTests
    {
        [Test]
        public void ParsePath_AbsolutePath_ReturnedUnchanged()
        {
            string path = Path.Combine("D:", "logs", "session.log");
            Assert.That(Utility.ParsePath(path), Is.EqualTo(path));
        }

        [Test]
        public void ParsePath_BareRelativePath_ReturnedUnchanged()
        {
            const string path = "logs\\session.log";
            Assert.That(Utility.ParsePath(path), Is.EqualTo(path));
        }

        [Test]
        public void ParsePath_DotSlashPrefix_ResolvedAgainstAppBaseDirectory()
        {
            string result = Utility.ParsePath(@".\logs\session.log");
            string expected = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs\\session.log");
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ParsePath_DateToken_AfterBackslash_Substituted()
        {
            string today = DateTime.Now.Date.ToString("yyyyMMdd");
            Assert.That(Utility.ParsePath(@"logs\{DATE:yyyyMMdd}\session.log"),
                Is.EqualTo($@"logs\{today}\session.log"));
        }

        [Test]
        public void ParsePath_DateToken_AfterForwardSlash_Substituted()
        {
            // Regression: the previous regex required a literal `\` before {DATE:...} and
            // silently left forward-slash paths unsubstituted.
            string today = DateTime.Now.Date.ToString("yyyyMMdd");
            Assert.That(Utility.ParsePath("logs/{DATE:yyyyMMdd}/session.log"),
                Is.EqualTo($"logs/{today}/session.log"));
        }

        [Test]
        public void ParsePath_DateToken_AtStart_Substituted()
        {
            // Regression: the previous regex required a literal `\` before {DATE:...} and
            // silently left a leading-token path unsubstituted.
            string today = DateTime.Now.Date.ToString("yyyyMMdd");
            Assert.That(Utility.ParsePath("{DATE:yyyyMMdd}.log"),
                Is.EqualTo($"{today}.log"));
        }

        [Test]
        public void ParsePath_DateToken_WithDashSeparator_Substituted()
        {
            // Regression: e.g. `session-{DATE:yyyyMMdd}.log` was previously left unsubstituted
            // because the preceding character was `-`, not `\`.
            string today = DateTime.Now.Date.ToString("yyyyMMdd");
            Assert.That(Utility.ParsePath(@"logs\session-{DATE:yyyyMMdd}.log"),
                Is.EqualTo($@"logs\session-{today}.log"));
        }

        [Test]
        public void ParsePath_MultipleDateTokens_AllSubstituted()
        {
            string year = DateTime.Now.Date.ToString("yyyy");
            string monthDay = DateTime.Now.Date.ToString("MMdd");
            Assert.That(Utility.ParsePath(@"logs\{DATE:yyyy}\{DATE:MMdd}\session.log"),
                Is.EqualTo($@"logs\{year}\{monthDay}\session.log"));
        }

        [Test]
        public void ParsePath_NoDateToken_NoSubstitution()
        {
            const string path = @"logs\plain\session.log";
            Assert.That(Utility.ParsePath(path), Is.EqualTo(path));
        }

        [Test]
        public void ParsePath_InvalidDateFormat_ThrowsFormatException()
        {
            // Catch-all that used to swallow this is gone; config errors should surface at startup.
            // '%' is invalid as a sole format specifier for DateTime.ToString.
            Assert.That(() => Utility.ParsePath(@"logs\{DATE:%}\session.log"),
                Throws.InstanceOf<FormatException>());
        }
    }
}
