using System;
using Pandemonium.Types;

namespace Pandemonium.Functions
{
    public static class Ensureable
    {
        public static Func<Failable<TSource>, Failable<TSource>> Ensure<TSource>(Func<TSource, bool> predicate)
            => (Failable<TSource> _) => _.Ensure(predicate);

        public static Func<Failable<TSource>, Failable<TSource>> Ensure<TSource>(Func<TSource, bool> predicate, Exception error)
            => (Failable<TSource> _) => _.Ensure(predicate, error);
    }
}