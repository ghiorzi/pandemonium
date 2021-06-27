using System;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public TResult Match<TResult>(Func<T, TResult> value, Func<TResult> empty)
            => HasValue ? value(Value) : empty();

        public Nothing Match(Action<T> value, Action empty)
        {
            var self = this;

            HasValue
                .Do(() => value(self.Value))
                .Otherwise(() => empty());
            
            return Nothing.Of();
        }
    }
}