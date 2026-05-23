#region Using Directives

using System.Text;

#endregion

namespace QuickFix.Enhancements.Extensions
{
	public static class SessionIdExtensions
	{
		public static string DescribeSession(this SessionID sessionId)
		{
			StringBuilder prefix = new StringBuilder(sessionId.BeginString).Append('-')
																																		 .Append(sessionId.SenderCompID);
			if (SessionID.IsSet(sessionId.SenderSubID))
				prefix.Append('_').Append(sessionId.SenderSubID);

			if (SessionID.IsSet(sessionId.SenderLocationID))
				prefix.Append('_').Append(sessionId.SenderLocationID);

			if (SessionID.IsSet(sessionId.TargetCompID))
				prefix.Append('-').Append(sessionId.TargetCompID);

			if (SessionID.IsSet(sessionId.TargetSubID))
				prefix.Append('_').Append(sessionId.TargetSubID);

			if (SessionID.IsSet(sessionId.TargetLocationID))
				prefix.Append('_').Append(sessionId.TargetLocationID);

			if (sessionId.SessionQualifier.Length != 0)
				prefix.Append('-').Append(sessionId.SessionQualifier);

			return prefix.ToString();
		}
	}
}