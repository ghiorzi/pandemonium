using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        ///  It returns true if @this is past date
        /// </summary>
        public static bool Past(this DateTime @this) 
            => @this < DateTime.Now;
    }
}