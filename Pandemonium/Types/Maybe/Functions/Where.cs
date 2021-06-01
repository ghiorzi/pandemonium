using System;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public Failable<T> Where(Func<T, bool> predicate)
            => Where(predicate, new WhereException());

        public Failable<T> Where(Func<T, bool> predicate, Exception error)
        {
            if (Empty)
                return Failable.FromException<T>(new WhereException());
            else if (predicate(_value) is false)
                return Failable.FromException<T>(error);

            return Failable.From(_value);
        }
    }
}