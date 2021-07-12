using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static Func<Failable<T>> Pipe<T>(this Failable<T> self, params Func<Failable<T>, Failable<T>>[] functions)
            => () => Pandemonium.Functions.Pipe<Failable<T>>(functions)(self);
    }
}
