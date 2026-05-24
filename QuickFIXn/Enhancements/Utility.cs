using System;
using System.IO;
using System.Text.RegularExpressions;

namespace QuickFix.Enhancements
{
    public static class Utility
    {
        // FP Enhancement: 2026-05-24 — normalises a configured path. Two transformations:
        //   1. `.\` prefix is resolved against AppDomain.CurrentDomain.BaseDirectory so configs can ship app-relative paths.
        //   2. `{DATE:format}` tokens are substituted with today's date in the supplied format string. Used at startup to
        //      stamp the current date into log/store paths; tokens can appear anywhere in the path (not just after a `\`).
        //      Invalid format strings deliberately propagate the FormatException — config errors should surface at startup,
        //      not be silently swallowed.
        public static string ParsePath(string relativePath)
        {
            var parsedPath = relativePath.StartsWith(@".\", StringComparison.Ordinal)
                ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath.Substring(2))
                : relativePath;

            return Regex.Replace(parsedPath, @"\{DATE:(?<Format>[^}]*)\}",
                m => DateTime.Now.Date.ToString(m.Groups["Format"].Value));
        }
    }
}
