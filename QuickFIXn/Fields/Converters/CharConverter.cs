using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    /// Converts char to/from string
    /// </summary>
    public static class CharConverter 
    {
        /// <summary>
        /// Convert string to char
        /// </summary>
        /// <exception cref="FieldConvertError"/>
        public static char Convert(string c)
        {
            if (c.Length != 1)
                throw new FieldConvertError("could not convert string to char, str=" + c);
            return c[0];
        }

        /// <summary>
        /// Converts char to string
        /// </summary>
        public static string Convert(char c)
        {
            return c.ToString();
        }

        // FP Enhancement: 2026-05-24 — opt-in lenient overload. When `allowTruncation` is true, accept multi-char strings by taking the first character; otherwise behave like the strict overload. Used by FieldMap/DataDictionary when the session enables AllowStringTruncationForCharFields for counterparties that send over-wide char fields.
        public static char Convert(string c, bool allowTruncation)
        {
            if (c.Length == 0 || (c.Length != 1 && !allowTruncation))
                throw new FieldConvertError("could not convert string to char, str=" + c);
            return c[0];
        }
    }
}
