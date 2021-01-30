using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns the day after @this.
        /// </summary>
        public static DateTime Tomorrow(this DateTime @this) 
            => @this.AddDays(1);
    }
}