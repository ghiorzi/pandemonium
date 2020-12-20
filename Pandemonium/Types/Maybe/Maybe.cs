using System;

namespace Pandemonium.Types
{
    /// <summary>
    /// Semantic container to represent a value that may or may not exist 
    /// </summary>
    [Serializable]
    public partial struct Maybe<T>
    {
        public static Maybe<T> None => new Maybe<T>();

        public bool HasValue => _value != null;
        public bool HasNoValue => !HasValue;

        private readonly T _value;

        private Maybe(T value)
            => _value = value;
    }
}