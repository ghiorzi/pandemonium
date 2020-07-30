namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a positive number
        /// </summary>
        public static bool Positive(this sbyte @this) 
            => @this > 0;

        /// <summary>
        /// Returns true if value is a positive number
        /// </summary>
        public static bool Positive(this short @this) 
            => @this > 0;

        /// <summary>
        /// Returns true if value is a positive number
        /// </summary>
        public static bool Positive(this int @this) 
            => @this > 0;

        /// <summary>
        /// Returns true if value is a positive number
        /// </summary>
        public static bool Positive(this long @this) 
            => @this > 0;

        /// <summary>
        /// Returns true if value is a positive number
        /// </summary>
        public static bool Positive(this float @this) 
            => @this > 0;

        /// <summary>
        /// Returns true if value is a positive number
        /// </summary>
        public static bool Positive(this double @this) 
            => @this > 0;

        /// <summary>
        /// Returns true if value is a positive number
        /// </summary>
        public static bool Positive(this decimal @this) 
            => @this > 0;
    }
}