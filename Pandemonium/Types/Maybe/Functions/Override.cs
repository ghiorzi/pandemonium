namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public override bool Equals(object obj)
            => _value.Equals(obj);

        public override int GetHashCode()
        {
            if (HasNoValue)
                return 0;

            return _value.GetHashCode();
        }

        public override string ToString()
        {
            if (HasNoValue)
                return "It has no value";

            return _value.ToString();
        }
    }
}