namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public bool HasValue => _value.NotDefault();
        public bool Empty => !HasValue;

        private readonly T _value;

        internal Maybe(T value)
            => _value = value;
    }
}