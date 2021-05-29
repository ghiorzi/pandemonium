using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It subtracts @days
        /// </summary>
        public static DateTime Subtract(this DateTime self, int days) 
            => self.AddDays(days * -1);
    }
}