namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotEmpty(this string self) 
            => !string.IsNullOrEmpty(self);
    }
}