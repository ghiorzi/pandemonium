using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  It returns true if the value is between @min and @max, otherwise false
        /// </summary>
        public static bool Between(this DateTime @this, DateTime min, DateTime max)
            => min.CompareTo(@this) == -1 && @this.CompareTo(max) == -1;
    }
}