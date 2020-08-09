using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Returns true if @this is past date
        /// </summary>
        public static bool Past(this DateTime @this) 
            => @this < DateTime.Now;
    }
}