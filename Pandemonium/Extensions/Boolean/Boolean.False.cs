namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Returns true if value is false
        /// </summary>
        public static bool False(this bool @this) => !@this;
    }
}