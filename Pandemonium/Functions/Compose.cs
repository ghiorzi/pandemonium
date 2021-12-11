using System;
using System.Linq;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static Func<T, T> Compose<T>(params Func<T, T>[] functions)
            => (T value)
                => functions
                      .Reverse<Func<T, T>>()
                      .Aggregate<Func<T, T>, T>(value, (value, function) => function(value));
    }
}