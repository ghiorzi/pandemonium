using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Func<Failable<T>> Where<T>(this Func<Failable<T>> self, Func<T, bool> predicate)
            => self().Where(predicate);
        
        public static Func<Failable<T>> Where<T>(this Func<Failable<T>> self, Func<T, bool> predicate, Exception error)
            => self().Where(predicate, error);
    }
}