using System.Text.RegularExpressions;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Match(this string self, string pattern) 
            => Regex.IsMatch(self, pattern);

        public static bool Match(this string self, string pattern, RegexOptions options)
            => Regex.IsMatch(self, pattern, options);
    }
}