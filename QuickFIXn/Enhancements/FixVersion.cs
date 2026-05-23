#region Using Directives

using System.Text.RegularExpressions;
using static System.Int32;

#endregion

namespace QuickFix.Enhancements
{
    public class FixVersion
    {
        public int Id { get; set; }
        public int Major { get; private init; }
        public int Minor { get; private init; }

        public string DisplayName => $"{Major}.{Minor}";

        public static FixVersion FromBeginString(string beginString)
        {
            var rgx = new Regex(@".*?(?<Major>\d)\.(?<Minor>\d)", RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Multiline);

            var version = new FixVersion
                          {
                              Major = Parse(rgx.Match(beginString).Groups["Major"].Value),
                              Minor = Parse(rgx.Match(beginString).Groups["Minor"].Value)
                          };

            return version;
        }
    }
}