using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        internal Failable<T> Do(Action action)
        {
            if(Succeeded)
                action();

            return this;
        }

        internal Failable<T> Do(Action<T> action)
        {
            #pragma warning disable CS8604
            if(Succeeded)
                action(_value);

            return this;
        }
    }
}