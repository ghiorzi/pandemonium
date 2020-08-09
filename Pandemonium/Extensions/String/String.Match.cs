using System.Text.RegularExpressions;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool Match(this string input, string pattern) 
            => Regex.IsMatch(input, pattern);

        public static bool Match(this string input, string pattern, RegexOptions options)
            => Regex.IsMatch(input, pattern, options);
    }
}