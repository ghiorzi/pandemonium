using System;

namespace Pandemonium.Types
{
    public sealed class Runnable<TSource>
    {
        private readonly Func<TSource, bool> _predicate;

        internal Runnable(Func<TSource, bool> predicate)
            => _predicate = predicate;

        public Action<TSource> Do(Action<TSource> action)
        {
            return (TSource value) =>
            {
                if (_predicate(value))
                    action(value);
            };
        }

        public Func<TSource, Maybe<TResult>> Do<TResult>(Func<TSource, TResult> function)
        {
            return (TSource value) =>
            {
                if (_predicate(value))
                    return function(value);

                return default;
            };
        }
    }
}