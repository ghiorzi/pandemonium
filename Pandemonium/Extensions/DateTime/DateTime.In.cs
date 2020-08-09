using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Returns true if @this is in @values
        /// </summary>
        public static bool In(this DateTime @this, params DateTime[] values)
            => Array.IndexOf(values, @this) != -1; 
    }
}