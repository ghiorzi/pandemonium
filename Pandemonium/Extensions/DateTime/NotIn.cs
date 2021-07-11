using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotIn(this DateTime self, params DateTime[] values)
            => Array.IndexOf(values, self) == -1;
    }
}