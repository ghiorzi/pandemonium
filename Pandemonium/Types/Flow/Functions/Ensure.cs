using System;

namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        public Flow<T, TError> Ensure(Predicate<T> predicate, TError error)
        {
            if (Failed)
                return this;

            if (predicate(_value).False())
                return Flow.Of<T, TError>(error);

            return this;
        }
    }
}