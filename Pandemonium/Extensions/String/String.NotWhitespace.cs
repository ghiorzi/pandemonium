using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static bool NotWhitespace(this string @this) 
            => !string.IsNullOrWhiteSpace(@this);
    }
}