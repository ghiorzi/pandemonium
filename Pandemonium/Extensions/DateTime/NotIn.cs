using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  It returns true if self is not in @values
        /// </summary>
        public static bool NotIn(this DateTime self, params DateTime[] values)
            => Array.IndexOf(values, self) == -1;
    }
}