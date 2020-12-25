using System;
using System.Collections.Generic;
using System.Linq;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns true if there is no value that matches the predicate
        /// </summary>
        public static bool None<T>(this IEnumerable<T> @this, Func<T, bool> predicate)
            => !@this.Any(predicate);
    }
}