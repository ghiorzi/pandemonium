using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool None(this string self) 
            => string.IsNullOrEmpty(self);

        public static bool None(this string self, params string[] values) 
            => self.Any(values) is false;

        public static bool None(this string self, StringComparison comparison, params string[] values)
            => self.Any(comparison, values) is false;
    }
}