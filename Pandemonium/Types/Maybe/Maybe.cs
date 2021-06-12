using System;

namespace Pandemonium.Types
{
    public static partial class Maybe 
    {
        public static Nothing Nothing => Nothing.Of();
    }

    /// <summary>
    /// Semantic container to represent a value that may or may not exist 
    /// </summary>
    [Serializable]
    public partial struct Maybe<T>
    {
        public bool HasValue => _value.NotDefault();
        public bool Empty => !HasValue;

        private readonly T _value;

        internal Maybe(T value)
            => _value = value;
    }
}