namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotNullable<T>(this T @this) 
            => default(T) != null;
    }
}