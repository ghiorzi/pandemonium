using System.Text.RegularExpressions;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static MatchCollection Matches(this string self, string pattern)
            => Regex.Matches(self, pattern);
        
        public static MatchCollection Matches(this string self, string pattern, RegexOptions options)
            => Regex.Matches(self, pattern, options);
    }
}