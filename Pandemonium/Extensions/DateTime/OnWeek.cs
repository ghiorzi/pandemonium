using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if @this is on week
        /// </summary>
        public static bool OnWeek(this DateTime @this) 
            => !@this.OnWeekend();
    }
}