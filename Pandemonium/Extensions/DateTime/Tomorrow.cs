using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns the day after self.
        /// </summary>
        public static DateTime Tomorrow(this DateTime self) 
            => self.AddDays(1);
    }
}