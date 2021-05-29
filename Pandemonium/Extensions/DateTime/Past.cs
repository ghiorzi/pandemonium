using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  It returns true if self is past date
        /// </summary>
        public static bool Past(this DateTime self) 
            => self < DateTime.Now;
    }
}