using System.Text.RegularExpressions;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static MatchCollection Matches(this string input, string pattern)
            => Regex.Matches(input, pattern);
        
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options)
            => Regex.Matches(input, pattern, options);
    }
}