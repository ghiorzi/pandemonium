using System;

namespace Pandemonium.Types
{
    [Serializable]
    public partial struct Failable<T> : IEquatable<Failable<T>>
    {
        public bool Failed { get; private set; }
        public bool Succeeded => !Failed;
        public Exception Error => _error;

        private readonly T _value;
        private readonly Exception _error;

        internal Failable(Exception error)
        {
            _error = error;
            _value = default;
            Failed = true;
        }

        internal Failable(T value)
        {
            _error = default;
            _value = value;
            Failed = false;
        }

        public bool Equals(Failable<T> other)
            => this == other;

        #region Overrides
        public override bool Equals(object @value)
            => @value is Failable<T> failable && this == failable;

        public override int GetHashCode()
            => Error.GetHashCode() ^ _value.GetHashCode();

        public override string ToString()
            => Succeeded
                ? _value?.ToString()
                : Error?.ToString();
        #endregion
    }
}