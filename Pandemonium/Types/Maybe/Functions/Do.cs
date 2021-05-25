using System;
using Pandemonium.Configurations;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public Failable<TResult> Do<TResult>(Func<T, Failable<TResult>> functor)
        {
            if (Empty)
                return Failable.FromException<TResult>(Configuration.Exceptions.MaybeException);

            return functor(_value);
        }

        public Failable<TResult> Do<TResult>(Func<T, Failable<TResult>> functor, Exception error)
        {
            if (Empty)
                return Failable.FromException<TResult>(error);

            return functor(_value);
        }
    }
}