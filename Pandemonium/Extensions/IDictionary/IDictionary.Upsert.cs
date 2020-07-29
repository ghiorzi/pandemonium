using System.Collections.Generic;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Inserts the value if it does not exist, otherwise update it
        /// </summary>
        public static TValue Upsert<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue value)
        {
            bool notContains = !@this.ContainsKey(key);

            if (notContains)
                @this.Add(new KeyValuePair<TKey, TValue>(key, value));
            else
                @this[key] = value;

            return @this[key];
        }
    }
}