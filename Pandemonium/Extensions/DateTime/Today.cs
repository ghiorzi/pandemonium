using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if self is today
        /// </summary>
        public static bool Today(this DateTime self) 
            => self.Date == DateTime.Today;
    }
}