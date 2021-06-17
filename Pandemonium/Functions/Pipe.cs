using System;
using System.Linq;

namespace Pandemonium.Functions
{
    public static class Pipeable
    {
        public static Func<T, T> Pipe<T>(params Func<T, T>[] functions)
            => (T value)
                => functions
                      .Aggregate<Func<T, T>, T>(value, (value, function) => function(value));
    }
}