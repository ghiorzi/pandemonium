using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  It returns true if @this is a future date
        /// </summary>
        public static bool Future(this DateTime @this) 
            => @this > DateTime.Now;
    }
}