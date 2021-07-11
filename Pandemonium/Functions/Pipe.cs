using System;
using System.Linq;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static Func<T, T> Pipe<T>(params Func<T, T>[] functions)
            => (T value)
                => functions
                      .Aggregate<Func<T, T>, T>(value, (value, function) => function(value));
    }
}