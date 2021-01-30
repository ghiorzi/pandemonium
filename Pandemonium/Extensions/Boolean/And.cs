namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if both values are true
        /// </summary>
        public static bool And(this bool @this, bool value) 
            => @this && value;
    }
}