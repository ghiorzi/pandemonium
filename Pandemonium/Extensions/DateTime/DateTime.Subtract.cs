using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Subtracts @days
        /// </summary>
        public static DateTime Subtract(this DateTime @this, int days) 
            => @this.AddDays(days * -1);
    }
}