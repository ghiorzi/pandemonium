using System;
using System.Collections.Generic;
using System.Linq;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool None<T>(this IEnumerable<T> self, Func<T, bool> predicate)
            => !self.Any(predicate);
    }
}