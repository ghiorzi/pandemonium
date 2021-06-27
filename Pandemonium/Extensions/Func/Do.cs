using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Func<Failable<TSource>> Do<TSource>(this Func<Failable<TSource>> self, Action action)
            => self().Do(action);

        public static Func<Failable<TSource>> Do<TSource>(this Func<Failable<TSource>> self, Action<TSource> action)
            => self().Do(action);
    }
}