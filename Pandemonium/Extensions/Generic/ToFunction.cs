using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Func<TResult> ToFunction<TResult>(this TResult self) 
            => () => self;
    }
}