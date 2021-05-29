namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Empty(this string self) 
            => self == "" || self == null;
    }
}