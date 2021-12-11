using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public bool Failed { get; private set; }
        public bool Succeeded => !Failed;

        private readonly T? _value;
        private readonly Exception _error;

        internal Failable(Exception error)
        {
            _error = error;
            _value = default;
            Failed = true;
        }

        internal Failable(T value)
        {
            _error = new FailableException();
            _value = value;
            Failed = value is null;
        }
    }
}