using System;
using Pandemonium.Types;

namespace Pandemonium.Functions
{
    public static class Doable
    {
        public static Func<Failable<TSource>, Failable<TSource>> Do<TSource>(Action action)
            => (Failable<TSource> _) => _.Do(action);

        public static Func<Failable<TSource>, Failable<TSource>> Do<TSource>(Action<TSource> action)
            => (Failable<TSource> _) => _.Do(action);

        public static Func<Failable<TSource>, Failable<TSource>> Do<TSource>(Func<TSource, Failable<TSource>> functor)
            => (Failable<TSource> _) => _.Do(functor);
    }
}