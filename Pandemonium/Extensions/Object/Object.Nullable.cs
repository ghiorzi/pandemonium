namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if T is a nullable type, otherwise returns false
        /// </summary>
        public static bool Nullable<T>(this T @this) => default(T) == null;
    }
}