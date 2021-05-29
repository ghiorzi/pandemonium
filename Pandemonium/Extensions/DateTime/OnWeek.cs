using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if self is on week
        /// </summary>
        public static bool OnWeek(this DateTime self) 
            => !self.OnWeekend();
    }
}