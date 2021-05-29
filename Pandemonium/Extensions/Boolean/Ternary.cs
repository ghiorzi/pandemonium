namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns @true if value is true, otherwise returns @false
        /// </summary>
        public static T Ternary<T>(this bool self, T @true, T @false) 
            => self ? @true : @false;
    }
}