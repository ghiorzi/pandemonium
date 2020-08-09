using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns true if value has at least one of the keys, otherwise returns false
        /// </summary>
        public static bool Any<TKey, TValue>(this IDictionary<TKey, TValue> @this, params TKey[] keys)
        {
            foreach (TKey value in keys)
            {
                if (@this.ContainsKey(value))
                    return true;
            }

            return false;
        }
    }
}