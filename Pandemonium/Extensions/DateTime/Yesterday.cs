using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns the day before @this.
        /// </summary>
        public static DateTime Yesterday(this DateTime @this)
            => @this.AddDays(-1);
    }
}