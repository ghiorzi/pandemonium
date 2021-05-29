using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  It returns true if the value is between @min and @max, otherwise false
        /// </summary>
        public static bool Between(this DateTime self, DateTime min, DateTime max)
            => min.CompareTo(self) == -1 && self.CompareTo(max) == -1;
    }
}