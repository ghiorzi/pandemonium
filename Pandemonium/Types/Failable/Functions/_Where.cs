using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        internal Failable<T> Where(Func<T, bool> predicate)
            => Where(predicate, new WhereException());

        internal Failable<T> Where(Func<T, bool> predicate, Exception error)
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