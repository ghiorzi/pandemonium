namespace Pandemonium.Types
{
    public static class Maybe 
    {
        public static Maybe<T> From<T>(T value)
            => new Maybe<T>(value);
    }
}