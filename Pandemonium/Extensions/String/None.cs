using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool None(this string @this, params string[] values) 
            => !@this.Any(values);

        public static bool None(this string @this, StringComparison comparison, params string[] values)
            => !@this.Any(comparison, values);
    }
}