using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Returns true if @this is today
        /// </summary>
        public static bool Today(this DateTime @this) 
            => @this.Date == DateTime.Today;
    }
}