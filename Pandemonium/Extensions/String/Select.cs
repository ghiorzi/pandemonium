using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static string Select(this string self)
            => self;
        
        public static T Select<T>(this string self, Func<string, T> selector)
            => selector(self);
    }
}