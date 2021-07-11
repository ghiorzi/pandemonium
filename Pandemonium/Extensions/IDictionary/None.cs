using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {

        public static bool None<TKey, TValue>(this IDictionary<TKey, TValue> self, params TKey[] keys)
            => self.Any(keys) is false;
    }
}