namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool Whitespace(this string self) 
            => string.IsNullOrWhiteSpace(self);
    }
}