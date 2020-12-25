namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool NotNullable<T>(this T @this) 
            => default(T) != null;
    }
}