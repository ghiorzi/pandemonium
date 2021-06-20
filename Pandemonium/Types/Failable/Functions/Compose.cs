using System;
using Pandemonium.Types;
using Pandemonium.Functions;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Func<Failable<T>> Compose<T>(this Failable<T> self, params Func<Failable<T>, Failable<T>>[] functions)
            => ()
                => Composable.Compose<Failable<T>>(functions)(self);
    }
}