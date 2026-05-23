#region Using Directives

using System;
using System.Collections.Generic;

#endregion

namespace QuickFix.Enhancements.Extensions
{
	public static class ArrayExtensions
	{
		public static void ForEach<T>(this IEnumerable<T> target, Action<T> action)
		{
			foreach (T item in target)
			{
				action(item);
			}
		}
	}
}