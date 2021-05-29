namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if self contains only whitespaces
        /// </summary>
        public static bool Whitespace(this string self) 
            => string.IsNullOrWhiteSpace(self);
    }
}