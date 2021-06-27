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
        public bool HasValue => Value.NotDefault();
        public bool Empty => !HasValue;

        private readonly T Value;

        internal Maybe(T value)
            => Value = value;
    }
}