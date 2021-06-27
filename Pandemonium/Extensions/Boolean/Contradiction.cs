namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool Contradiction(this bool self)
            => self is false;
    }
}