using System;
using System.Collections.Generic;
using System.Linq;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool None<T>(this IEnumerable<T> self, Func<T, bool> predicate)
            => !self.Any(predicate);
    }
}