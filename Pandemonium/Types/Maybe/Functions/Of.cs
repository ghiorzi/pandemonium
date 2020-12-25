namespace Pandemonium.Types
{
    public static class Maybe 
    {
        public static Maybe<T> Of<T>(T value)
            => new Maybe<T>(value);
    }
}