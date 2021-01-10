using System;
using System.Collections.Generic;
using System.Linq;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if @this has no elements
        /// </summary>
        public static bool NotEmpty<T>(this IEnumerable<T> @this) 
            => @this.Count() > 0;
    }
}