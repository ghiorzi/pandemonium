using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if @this is on weekend.
        /// </summary>
        public static bool OnWeekend(this DateTime @this)
        {
            bool saturday = @this.DayOfWeek == DayOfWeek.Saturday;
            bool sunday = @this.DayOfWeek == DayOfWeek.Sunday;

            return saturday || sunday;
        }
    }
}