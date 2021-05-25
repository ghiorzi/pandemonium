using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Failable<T> Do(Action action)
        {
            if(Succeeded)
                action();

            return this;
        }

        public Failable<T> Do(Action<T> action)
        {
            if(Succeeded)
                action(_value);

            return this;
        }

        public Failable<TResult> Do<TResult>(Func<T, Failable<TResult>> functor)
        {
            if (Failed)
                return Failable.FromException<TResult>(_error);

            return functor(_value);
        }
    }
}