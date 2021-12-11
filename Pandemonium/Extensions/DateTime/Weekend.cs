using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Weekend(this DateTime self)
        {
            bool saturday = self.DayOfWeek == DayOfWeek.Saturday;
            bool sunday = self.DayOfWeek == DayOfWeek.Sunday;

            return saturday || sunday;
        }
    }
}