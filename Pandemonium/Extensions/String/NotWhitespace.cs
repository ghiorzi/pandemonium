using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotWhitespace(this string self) 
            => !string.IsNullOrWhiteSpace(self);
    }
}