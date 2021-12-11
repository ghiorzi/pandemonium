using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  Indicates whether the specified date is a past date
        /// </summary>
        public static bool Past(this DateTime self) 
            => self < DateTime.Now;
    }
}