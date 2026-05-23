#region Directives

using System;
using System.Threading;

#endregion

namespace QuickFix.Enhancements.Extensions
{
	public static class DateTimeExtenisons
	{
		public static bool EvaluateDateIsInPeriod(this DateTime candidate, string start, string end, DayOfWeek dayOfWeek)
		{
			return candidate.EvaluateDateIsInPeriod(TimeSpan.Parse(start), TimeSpan.Parse(end), dayOfWeek);
		}

		public static bool EvaluateDateIsInPeriod(this DateTime candidate, TimeSpan startTime, TimeSpan endTime, DayOfWeek dayOfWeek)
		{
			var offset = startTime < endTime ? 0 : 1;

			// Start of candidate week
			var firstDayOfWeek = Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
			var startOfCandidateWeek = candidate.AddDays(-(candidate.DayOfWeek - firstDayOfWeek)).Date;
			// Evaluate start of period
			var startOfEvaluationPeriod = startOfCandidateWeek.AddDays(dayOfWeek - firstDayOfWeek).Add(startTime);
			//..and end
			var endOfEvaluationPeriod = startOfCandidateWeek.AddDays(dayOfWeek - firstDayOfWeek + offset).Add(endTime);

			return candidate >= startOfEvaluationPeriod && candidate < endOfEvaluationPeriod;
		}
	}
}