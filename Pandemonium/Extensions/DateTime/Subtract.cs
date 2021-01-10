using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It subtracts @days
        /// </summary>
        public static DateTime Subtract(this DateTime @this, int days) 
            => @this.AddDays(days * -1);
    }
}