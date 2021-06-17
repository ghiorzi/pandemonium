using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool NotWhitespace(this string self) 
            => !string.IsNullOrWhiteSpace(self);
    }
}