using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Func<TSource, bool> Not<TSource>(this Func<TSource, bool> self)
            => value => self(value) is false;
    }
}