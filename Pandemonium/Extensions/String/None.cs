using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool None(this string self, params string[] values) 
            => !self.Any(values);

        public static bool None(this string self, StringComparison comparison, params string[] values)
            => !self.Any(comparison, values);
    }
}