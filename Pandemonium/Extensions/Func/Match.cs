using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Nothing Match<T>(this Func<Failable<T>> self, Action<T> success, Action<Exception> failure)
            => self().Match(success, failure);
    }
}