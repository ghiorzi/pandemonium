namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool Nullable<T>(this T @this) 
            => default(T) == null;
    }
}