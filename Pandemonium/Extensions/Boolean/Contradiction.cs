namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Contradiction(this bool self)
            => self is false;
    }
}