using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Func<Failable<T>> Where<T>(this Failable<T> _, Func<T, bool> predicate)
            => Where<T>(_, predicate, new WhereException());

        public static Func<Failable<T>> Where<T>(this Failable<T> _, Func<T, bool> predicate, Exception error)
        {
            return () => 
            {
                if (_.Failed)
                    return _;
                #pragma warning disable CS8604
                else if (predicate(_.Value) is false)
                    return Failable.FromException<T>(error);

                return _;
            };
        }
    }
}