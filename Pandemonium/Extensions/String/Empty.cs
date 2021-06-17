using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool Empty(this string self) 
            => string.IsNullOrEmpty(self);
    }
}