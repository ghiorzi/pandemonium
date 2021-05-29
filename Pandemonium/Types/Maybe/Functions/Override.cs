namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public override bool Equals(object other)
            => _value.Equals(other);

        public override int GetHashCode()
        {
            if (Empty)
                return 0;

            return _value.GetHashCode();
        }

        public override string ToString()
        {
            if (Empty)
                return "It has no value";

            return _value?.ToString();
        }
    }
}