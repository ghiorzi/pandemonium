using System;
using System.Collections.Generic;
using System.Linq;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if @this has no elements
        /// </summary>
        public static bool NotEmpty<T>(this IEnumerable<T> @this) 
            => @this.Count() > 0;
    }
}