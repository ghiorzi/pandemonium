using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Returns true if @this is not in @values
        /// </summary>
        public static bool NotIn(this DateTime @this, params DateTime[] values)
            => Array.IndexOf(values, @this) == -1;
    }
}