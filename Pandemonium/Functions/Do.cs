using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static Func<Failable<TSource>, Failable<TSource>> Do<TSource>(Action action)
            => (Failable<TSource> _) => _.Do(action);

        public static Func<Failable<TSource>, Failable<TSource>> Do<TSource>(Action<TSource> action)
            => (Failable<TSource> _) => _.Do(action);
    }
}