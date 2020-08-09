using System.Text.RegularExpressions;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static bool Numeric(this string @this) 
            => !Regex.IsMatch(@this, "[^0-9]");
    }
}