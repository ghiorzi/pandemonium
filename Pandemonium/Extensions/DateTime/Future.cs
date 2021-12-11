using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  Indicates whether the specified date is a future date
        /// </summary>
        public static bool Future(this DateTime self) 
            => self > DateTime.Now;
    }
}