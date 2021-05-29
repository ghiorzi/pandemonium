using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It inserts the value if it does not exist, otherwise update it
        /// </summary>
        public static TValue Upsert<TKey, TValue>(this IDictionary<TKey, TValue> self, TKey key, TValue value)
        {
            bool notContains = !self.ContainsKey(key);

            if (notContains)
                self.Add(new KeyValuePair<TKey, TValue>(key, value));
            else
                self[key] = value;

            return self[key];
        }
    }
}