namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public static implicit operator Maybe<T>(T value)
            => Maybe.From(value);
        
        public static bool operator ==(Maybe<T> self, Maybe<T> that)
            => self.Equals(that);

        public static bool operator !=(Maybe<T> self, Maybe<T> that)
            => !(self == that);
    }
}