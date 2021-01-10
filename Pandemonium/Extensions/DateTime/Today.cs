using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if @this is today
        /// </summary>
        public static bool Today(this DateTime @this) 
            => @this.Date == DateTime.Today;
    }
}