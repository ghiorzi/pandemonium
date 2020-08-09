using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool NotIn(this string @this, params string[] values)
            => Array.IndexOf(values, @this) == -1;
    }
}