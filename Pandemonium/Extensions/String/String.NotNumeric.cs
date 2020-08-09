namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static bool NotNumeric(this string @this) 
            => !@this.Numeric();
    }
}