using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public static implicit operator Failable<T>(T value)
            => Failable.From(value);
        
        public static implicit operator Failable<T>(Exception error)
            => Failable.FromException<T>(error);
    }
}