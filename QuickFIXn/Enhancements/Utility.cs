#region Using Directives

using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using QuickFix.Util;

#endregion

namespace QuickFix.Enhancements
{
	public static class Utility
	{
		public static string ParsePath(string relativePath)
		{
			try
			{
				var parsedPath = relativePath.StartsWith(@".\", StringComparison.Ordinal)
					? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath.Substring(2))
					: relativePath;

				var match = Regex.Match(parsedPath, @"\{DATE:(?<Format>.*)\}");

				return match.Success
					       ? Regex.Replace(parsedPath, @"(.*)\\\{DATE:(?<Format>.*)\}",
                               $@"$1\{DateTime.Now.Date.ToString(match.Groups["Format"].Value)}", RegexOptions.IgnoreCase)
					       : parsedPath;
			}
			catch
			{
				return relativePath;
			}
		}
	}
}