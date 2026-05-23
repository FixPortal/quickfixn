#region Using Directives

using System;

#endregion

namespace QuickFix.Enhancements.Extensions
{
	public static class SettingsDictionaryExtensions
	{
		public static T GetEnumValue<T>(this SettingsDictionary target, string key, T defaultValue)
		{
			try
			{
				return (T) Enum.Parse(typeof (T), target.GetString(key));
			}
			catch
			{
				return defaultValue;
			}
		}

		public static int GetIntOrDefault(this SettingsDictionary target, string key, int defaultValue)
		{
			try
			{
				return target.GetInt(key);
			}
			catch (Exception)
			{
				return defaultValue;
			}
		}
	}
}