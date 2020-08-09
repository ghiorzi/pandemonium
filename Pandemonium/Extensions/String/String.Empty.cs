namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool Empty(this string @this) 
            => @this == "" || @this == null;
    }
}