using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static Func<Failable<TSource>, Failable<TSource>> Where<TSource>(Func<TSource, bool> predicate)
            => (Failable<TSource> _) => _.Where(predicate);

        public static Func<Failable<TSource>, Failable<TSource>> Where<TSource>(Func<TSource, bool> predicate, Exception error)
            => (Failable<TSource> _) => _.Where(predicate, error);
    }
}