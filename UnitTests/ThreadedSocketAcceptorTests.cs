using System.IO;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using QuickFix;
using QuickFix.Logger;
using QuickFix.Store;

namespace UnitTests
{
    [TestFixture]
    public class ThreadedSocketAcceptorTests
    {
        private static string Config = $@"
[DEFAULT]
StartTime = 00:00:00
EndTime = 23:59:59
ConnectionType = acceptor
SocketAcceptHost = 127.0.0.1
SocketAcceptPort = 10000
FileStorePath = {TestContext.CurrentContext.TestDirectory}\store
FileLogPath = {TestContext.CurrentContext.TestDirectory}\log
UseDataDictionary = N

[SESSION]
SenderCompID = sender
TargetCompID = target
BeginString = FIX.4.4
";

        private static SessionSettings CreateSettings()
        {
            return new SessionSettings(new StringReader(Config));
        }

        [Test]
        [Ignore("Fails due to file being locked; ignored for now.Add in debounce when time permits")]
        public void TestRecreation()
        {
            StartStopAcceptor();
            StartStopAcceptor();
            StartStopAcceptor();
        }

        private static void StartStopAcceptor()
        {
            var settings = CreateSettings();
            var lf = new FileLogFactory(settings);

            var acceptor = new ThreadedSocketAcceptor(
                new NullApplication(),
                new FileStoreFactory(settings),
                settings,
                lf);
            acceptor.Start();
            acceptor.Dispose();
        }
		#region FixPortal Enhancement
		private static ThreadedSocketAcceptor CreateAcceptor_CP()
        {
			QuickFix.Enhancements.DataDictionary.IQFCoreSetup setup = NSubstitute.Substitute.For<QuickFix.Enhancements.DataDictionary.IQFCoreSetup>();
	        IMessageFactory messageFactory = NSubstitute.Substitute.For<IMessageFactory>();
            var settings = CreateSettings();
            return new ThreadedSocketAcceptor(
                new NullApplication(),
                new FileStoreFactory(settings),
                settings,
                new FileLogFactory(settings), messageFactory, setup);
        }
        [Test]
        [Ignore("Fails due to file being locked; ignored for now.Add in debounce when time permits")]
        public void TestRecreationCP()
        {
            StartStopAcceptorCP();
            StartStopAcceptorCP();
            StartStopAcceptorCP();
        }
        private static void StartStopAcceptorCP()
        {
            var acceptor = CreateAcceptor_CP();
            acceptor.Start();
            acceptor.Dispose();
        }
		#endregion
    }
}
