namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Return true when at least one value is true
        /// </summary>
        public static bool Or(this bool @this, bool value) => @this || value;
    }
}