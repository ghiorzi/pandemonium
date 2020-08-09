using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static string Concat(this string @this, string @string)
            => string.Concat(@this, @string);
    }
}