using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static Func<Failable<T>> Compose<T>(this Failable<T> self, params Func<Failable<T>, Failable<T>>[] functions)
            => () => Pandemonium.Functions.Compose<Failable<T>>(functions)(self);
    }
}
