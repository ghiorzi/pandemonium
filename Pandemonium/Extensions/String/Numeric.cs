using System.Text.RegularExpressions;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Numeric(this string self) 
            => !Regex.IsMatch(self, "[^0-9]");
    }
}