using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        ///  IT returns true if @this is not in @values
        /// </summary>
        public static bool NotIn(this DateTime @this, params DateTime[] values)
            => Array.IndexOf(values, @this) == -1;
    }
}