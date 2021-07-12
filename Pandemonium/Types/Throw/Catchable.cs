using System;

namespace Pandemonium.Types
{
    public sealed class Catchable<TSource, TError> where TError : Exception, new()
    {
        private readonly Func<TSource, bool> _predicate;

        internal Catchable(Func<TSource, bool> predicate)
            => _predicate = predicate;

        public Action<TSource> Catch(Action<TError> handler)
        {
            return (TSource value) =>
            {
                if (_predicate(value))
                    handler(new TError());
            };
        }

        public Func<TSource, Maybe<TResult>> Catch<TResult>(Func<TError, TResult> handler)
        {
            return (TSource value) =>
            {
                if (_predicate(value))
                    return handler(new TError());

                return default;
            };
        }

        public Action<TSource> Throw()
            => new Throwable<TSource, TError>(_predicate).Throw();
    }
}