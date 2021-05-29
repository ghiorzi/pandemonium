using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotIn(this string self, params string[] values)
            => Array.IndexOf(values, self) == -1;
    }
}