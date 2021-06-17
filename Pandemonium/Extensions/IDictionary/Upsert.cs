using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static TValue Upsert<TKey, TValue>(this IDictionary<TKey, TValue> self, TKey key, TValue value)
        {
            bool notContains = self.ContainsKey(key) is false;

            if (notContains)
                self.Add(new KeyValuePair<TKey, TValue>(key, value));
            else
                self[key] = value;

            return self[key];
        }
    }
}