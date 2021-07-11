using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static Func<TResult> ToFunction<TResult>(this TResult self) 
            => () => self;
    }
}