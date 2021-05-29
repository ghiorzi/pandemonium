using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if self is in @values
        /// </summary>
        public static bool In(this DateTime self, params DateTime[] values)
            => Array.IndexOf(values, self) != -1; 
    }
}