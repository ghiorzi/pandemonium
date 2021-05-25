using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public static implicit operator Failable<T>(T value)
            => Failable.From(value);
        
        public static implicit operator Failable<T>(Exception error)
            => Failable.FromException<T>(error);
        
        public static bool operator ==(Failable<T> a, Failable<T> b) 
            => a.Error == b.Error && a._value.Equals(b._value);
        public static bool operator !=(Failable<T> a, Failable<T> b) 
            => a.Error != b.Error || !a._value.Equals(b._value);
    }
}