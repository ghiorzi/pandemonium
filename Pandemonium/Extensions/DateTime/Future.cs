using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  It returns true if self is a future date
        /// </summary>
        public static bool Future(this DateTime self) 
            => self > DateTime.Now;
    }
}