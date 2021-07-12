namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public static implicit operator Maybe<T>(T value)
            => Maybe.From(value);
    }
}