namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns true if @this contains only whitespaces
        /// </summary>
        public static bool Whitespace(this string @this) 
            => string.IsNullOrWhiteSpace(@this);
    }
}