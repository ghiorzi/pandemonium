using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static IEnumerable<T> Copy<T>(this IEnumerable<T> self)
        {
            foreach (var value in self)
                yield return value.Clone();
        }
    }
}
