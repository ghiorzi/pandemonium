namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool NotNumeric(this string self) 
            => !self.Numeric();
    }
}