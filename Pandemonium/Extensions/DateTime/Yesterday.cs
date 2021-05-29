using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns the day before self.
        /// </summary>
        public static DateTime Yesterday(this DateTime self)
            => self.AddDays(-1);
    }
}