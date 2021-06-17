namespace Pandemonium
{
    public static partial class Functions
    {
        #pragma warning disable IDE0060
        public static bool NotNullable<T>(this T _) 
            => default(T) != null;
    }
}