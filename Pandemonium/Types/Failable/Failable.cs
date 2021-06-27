using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public bool Failed { get; private set; }
        public bool Succeeded => !Failed;

        internal readonly T? Value;
        internal readonly Exception? Error;

        internal Failable(Exception error)
        {
            Error = error;
            Value = default;
            Failed = true;
        }

        internal Failable(T value)
        {
            Error = default;
            Value = value;
            Failed = false;
        }
    }
}