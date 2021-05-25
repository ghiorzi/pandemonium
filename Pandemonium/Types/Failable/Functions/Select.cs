using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Failable<TResult> Select<TResult>(Func<T, TResult> selector)
        {
            if (Failed)
                return Failable.FromException<TResult>(_error);

            return Failable.From(selector(_value));
        }
    }
}