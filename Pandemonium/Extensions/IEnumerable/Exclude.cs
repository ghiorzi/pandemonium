using System;
using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static IEnumerable<T> Exclude<T>(this IEnumerable<T> self, Func<T, bool> predicate)
        {
            foreach (T item in self)
            {
                if (predicate(item) is false)
                    yield return item;
            }
        }
    }
}