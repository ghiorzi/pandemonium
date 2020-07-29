namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is null, otherwise returns false
        /// </summary>
        public static bool Null(this object @this) => @this == null;
    }
}