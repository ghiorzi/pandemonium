using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Failable<T> Where(Predicate<T> predicate)
            => Where(predicate, new WhereException());

        public Failable<T> Where(Predicate<T> predicate, Exception error)
        {
            if (Failed)
                return this;
            else if (predicate(_value) is false)
                return Failable.FromException<T>(error);

            return this;
        }
    }
}