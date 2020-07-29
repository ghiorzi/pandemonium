namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if T is not a nullable type, otherwise returns false
        /// </summary>
        public static bool NotNullable<T>(this T @this) 
            => default(T) != null;
    }
}