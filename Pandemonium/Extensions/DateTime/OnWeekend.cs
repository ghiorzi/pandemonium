using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if self is on weekend
        /// </summary>
        public static bool OnWeekend(this DateTime self)
        {
            bool saturday = self.DayOfWeek == DayOfWeek.Saturday;
            bool sunday = self.DayOfWeek == DayOfWeek.Sunday;

            return saturday || sunday;
        }
    }
}