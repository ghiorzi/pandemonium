using System;

namespace Pandemonium.Types
{
    public sealed class Throwable<TSource, TError> where TError : Exception, new()
    {
        private readonly Func<TSource, bool> _predicate;

        internal Throwable(Func<TSource, bool> predicate)
            => _predicate = predicate;

        internal Action<TSource> Throw()
        {
            return (TSource value) =>
            {
                if (_predicate(value))
                    throw new TError();
            };
        }
    }
}