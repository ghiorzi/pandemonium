using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool In(this string @this, params string[] values)
            => Array.IndexOf(values, @this) != -1;
    }
}