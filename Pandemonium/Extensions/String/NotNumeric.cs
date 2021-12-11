namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotNumeric(this string self) 
            => !self.Numeric();
    }
}