namespace Pandemonium.Types
{
    public static partial class Maybe 
    {
        public static Maybe<T> From<T>(T value)
            => new (value);
    }
}