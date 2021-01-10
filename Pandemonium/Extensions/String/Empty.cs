namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Empty(this string @this) 
            => @this == "" || @this == null;
    }
}