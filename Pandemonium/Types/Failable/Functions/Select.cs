using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Failable<T> Select()
        {
            if (Failed)
                #pragma warning disable CS8604
                return Failable.FromException<T>(Error);
            
            return Value;
        }

        public Failable<TResult> Select<TResult>(Func<T, TResult> selector)
        {
            if (Failed)
                #pragma warning disable CS8604
                return Failable.FromException<TResult>(Error);
            
            return Failable.From(selector(Value));
        }
    }
}