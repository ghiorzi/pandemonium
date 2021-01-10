namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotEmpty(this string @this) 
            => !string.IsNullOrEmpty(@this);
    }
}