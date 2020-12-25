using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool NotWhitespace(this string @this) 
            => !string.IsNullOrWhiteSpace(@this);
    }
}