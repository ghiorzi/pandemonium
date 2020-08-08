using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns the day after @this.
        /// </summary>
        public static DateTime Tomorrow(this DateTime @this) 
            => @this.AddDays(1);
    }
}