using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Returns true if @this is a future date
        /// </summary>
        public static bool Future(this DateTime @this) => @this > DateTime.Now;
    }
}