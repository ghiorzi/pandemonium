using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static string Join(this string self, string[] value)
            => string.Join(self, value);

        public static string Join<T>(this string self, IEnumerable<T> values)
            => string.Join(self, values);
    }
}