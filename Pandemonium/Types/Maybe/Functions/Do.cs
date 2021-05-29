using System;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public Failable<TResult> Do<TResult>(Func<T, Failable<TResult>> functor)
            => Do(functor, new DoException());

        public Failable<TResult> Do<TResult>(Func<T, Failable<TResult>> functor, Exception error)
        {
            if (Empty)
                return Failable.FromException<TResult>(error);

            return functor(_value);
        }
    }
}