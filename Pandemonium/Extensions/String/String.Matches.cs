using System.Text.RegularExpressions;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static MatchCollection Matches(this string input, string pattern)
            => Regex.Matches(input, pattern);
        
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options)
            => Regex.Matches(input, pattern, options);
    }
}