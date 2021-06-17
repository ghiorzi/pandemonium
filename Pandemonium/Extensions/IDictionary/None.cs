using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Extensions
    {

        public static bool None<TKey, TValue>(this IDictionary<TKey, TValue> self, params TKey[] keys)
            => self.Any(keys) is false;
    }
}