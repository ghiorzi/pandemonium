using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Returns true if the value is between @min and @max, otherwise false
        /// </summary>
        public static bool Between(this DateTime @this, DateTime min, DateTime max)
            => min.CompareTo(@this) == -1 && @this.CompareTo(max) == -1;
    }
}