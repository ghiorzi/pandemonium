using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static string Join(this string separator, string[] value)
            => string.Join(separator, value);

        public static string Join<T>(this string separator, IEnumerable<T> values)
            => string.Join(separator, values);
    }
}