using System;
using System.Linq;
using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static IEnumerable<T> Exclude<T>(this IEnumerable<T> self, Func<T, bool> predicate)
            => self.Where(value => predicate(value) is false);
    }
}