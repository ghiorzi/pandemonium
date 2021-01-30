namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Nullable<T>(this T @this) 
            => default(T) == null;
    }
}