namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Whitespace(this string self) 
            => string.IsNullOrWhiteSpace(self);
    }
}