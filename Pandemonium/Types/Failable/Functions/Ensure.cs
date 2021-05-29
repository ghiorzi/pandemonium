using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Failable<T> Ensure(Predicate<T> predicate)
            => Ensure(predicate, new EnsureException());

        public Failable<T> Ensure(Predicate<T> predicate, Exception error)
        {
            if (Failed)
                return this;

            if (predicate(_value) is false)
                return Failable.FromException<T>(error);

            return this;
        }
    }
}