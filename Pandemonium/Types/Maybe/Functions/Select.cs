using System;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public Failable<T> Select()
            => Select(x => x);

        public Failable<TResult> Select<TResult>(Func<T, TResult> selector)
            => Select(selector, new SelectException());

        public Failable<TResult> Select<TResult>(Func<T, TResult> selector, Exception error)
        {
            if (Empty)
                return Failable.FromException<TResult>(error);

            return Failable.From(selector(_value));
        }
    }
}