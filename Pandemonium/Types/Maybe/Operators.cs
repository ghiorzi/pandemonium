namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public static implicit operator Maybe<T>(T value)
            => Maybe.Of<T>(value);
        
        public static bool operator ==(Maybe<T> @this, Maybe<T> that)
            => @this.Equals(that);

        public static bool operator !=(Maybe<T> @this, Maybe<T> that)
            => !(@this == that);
    }
}