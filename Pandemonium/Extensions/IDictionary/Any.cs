using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool Any<TKey, TValue>(this IDictionary<TKey, TValue> self, params TKey[] keys)
        {
            foreach (TKey value in keys)
            {
                if (self.ContainsKey(value))
                    return true;
            }

            return false;
        }
    }
}