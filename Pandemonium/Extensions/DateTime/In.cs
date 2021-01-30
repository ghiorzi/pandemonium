using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if @this is in @values
        /// </summary>
        public static bool In(this DateTime @this, params DateTime[] values)
            => Array.IndexOf(values, @this) != -1; 
    }
}