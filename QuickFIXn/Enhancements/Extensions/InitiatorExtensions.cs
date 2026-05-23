#region Using Directives

#endregion

namespace QuickFix.Enhancements.Extensions
{
	public static class InitiatorExtensions
	{
		public static void StartIfStopped(this IInitiator target)
		{
			if (target.IsStopped) target.Start();
		}

		public static bool IsNotLoggedOn(this IInitiator target)
		{
			return target.IsLoggedOn == false;
		}
	}
}