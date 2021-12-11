namespace Pandemonium
{
    public static partial class Functions
    {
        #pragma warning disable IDE0060
        public static bool Nullable<T>(this T _) 
            => default(T) == null;
    }
}