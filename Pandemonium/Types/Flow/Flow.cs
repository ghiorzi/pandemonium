using System;

namespace Pandemonium.Types
{
    [Serializable]
    public partial struct Flow<T, TError>
    {
        public bool Failed { get;  private set; }        
        public bool Succeeded => !Failed;
        public TError Error => _error;

        private readonly T _value;
        private readonly TError _error;

        internal Flow(T value)
        {
            _error = default;
            _value = value;

            Failed = false;
        }

        internal Flow(TError error)
        {
            _error = error;
            _value = default;

            Failed = true;
        }
    }
}