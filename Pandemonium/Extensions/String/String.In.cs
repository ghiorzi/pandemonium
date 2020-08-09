using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static bool In(this string @this, params string[] values)
            => Array.IndexOf(values, @this) != -1;
    }
}