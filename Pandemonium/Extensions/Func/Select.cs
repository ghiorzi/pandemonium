using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Failable<T> Select<T>(this Func<Failable<T>> self)
            => self().Select();
        
        public static Failable<TResult> Select<TSource, TResult>(this Func<Failable<TSource>> self, Func<TSource, TResult> selector)
            => self().Select(selector);
    }
}