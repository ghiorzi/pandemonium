namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotNumeric(this string @this) 
            => !@this.Numeric();
    }
}