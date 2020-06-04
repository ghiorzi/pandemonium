namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if both values are true
        /// </summary>
        public static bool And(this bool @this, bool value) => @this && value;
    }
}