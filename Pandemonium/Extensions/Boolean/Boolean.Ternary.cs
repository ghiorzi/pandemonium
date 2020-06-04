namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns @true if value is true, otherwise returns @false
        /// </summary>
        public static T Ternary<T>(this bool @this, T @true, T @false) => @this ? @true : @false;
    }
}