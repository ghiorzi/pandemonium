using System.Collections.Generic;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if there's no key equal to @keys, otherwise returns false
        /// </summary>
        public static bool None<TKey, TValue>(this IDictionary<TKey, TValue> @this, params TKey[] keys)
        {
            return !@this.Any(keys);
        }
    }
}