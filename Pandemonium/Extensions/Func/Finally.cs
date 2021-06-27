using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static TResult Finally<TSource, TResult>(this Func<Failable<TSource>> self, Func<Failable<TSource>, TResult> function)
            => self().Finally(function);
    }
}