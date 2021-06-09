namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public override string ToString()
        {
            if (Empty)
                return "It has no value";

            // If it's not empty, then it must has value
            #pragma warning disable CS8602, CS8603
            return _value.ToString();
        }
    }
}