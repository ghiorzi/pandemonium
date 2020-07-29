namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not null, otherwise returns false
        /// </summary>
        public static bool NotNull(this object @this) => @this != null;
    }
}