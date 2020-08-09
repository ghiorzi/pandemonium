using System.Collections.Generic;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static string Join(this string separator, string[] value)
            => string.Join(separator, value);

        public static string Join<T>(this string separator, IEnumerable<T> values)
            => string.Join(separator, values);
    }
}