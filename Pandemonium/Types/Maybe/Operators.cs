namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public static implicit operator Maybe<T>(T value)
            => Maybe<T>.From(value);
        
        public static bool operator ==(Maybe<T> @this, Maybe<T> that)
            => @this.Equals(that);

        public static bool operator !=(Maybe<T> @this, Maybe<T> that)
            => !(@this == that);
    }
}