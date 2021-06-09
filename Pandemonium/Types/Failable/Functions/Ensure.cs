using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Failable<T> Ensure(Func<T, bool> predicate)
            => Ensure(predicate, new EnsureException());

        public Failable<T> Ensure(Func<T, bool> predicate, Exception error)
        {
            if (Failed)
                return this;
            #pragma warning disable CS8604
            else if (predicate(_value) is false)
                return Failable.FromException<T>(error);

            return this;
        }
    }
}