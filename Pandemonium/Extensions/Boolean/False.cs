namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is false
        /// </summary>
        public static bool False(this bool @this) 
            => !@this;
    }
}