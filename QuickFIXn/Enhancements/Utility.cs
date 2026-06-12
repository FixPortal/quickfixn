using System;
using System.IO;
using System.Text.RegularExpressions;

namespace QuickFix.Enhancements;

public static class Utility
{
    // FP Enhancement: 2026-05-24 — normalises a configured path. Two transformations:
    //   1. `.\` prefix is resolved against AppDomain.CurrentDomain.BaseDirectory so configs can ship app-relative paths.
    //   2. `{DATE:format}` tokens are substituted with the supplied (or current) local date. Tokens can appear anywhere
    //      in the path (not just after a `\`). Invalid format strings deliberately propagate the FormatException —
    //      config errors should surface at startup, not be silently swallowed.
    //
    // The optional `now` parameter lets callers (notably FileLog's day-rotation flow) inject a clock for testing and
    // for re-resolving the same template against a new "today" when the date rolls over.
    public static string ParsePath(string relativePath, DateTime? now = null)
    {
        var effectiveDate = (now ?? DateTime.Now).Date;

        var parsedPath = (relativePath.StartsWith(@".\", StringComparison.Ordinal) || relativePath.StartsWith(@"./", StringComparison.Ordinal))
            ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath.Substring(2))
            : relativePath;

        return Regex.Replace(parsedPath, @"\{DATE:(?<Format>[^}]*)\}",
            m => effectiveDate.ToString(m.Groups["Format"].Value, System.Globalization.CultureInfo.InvariantCulture));
    }
}
