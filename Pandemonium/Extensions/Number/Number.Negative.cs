namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a negative number
        /// </summary>
        public static bool Negative(this sbyte @this) 
            => @this < 0;

        /// <summary>
        /// Returns true if value is a negative number
        /// </summary>
        public static bool Negative(this short @this) 
            => @this < 0;

        /// <summary>
        /// Returns true if value is a negative number
        /// </summary>
        public static bool Negative(this int @this) 
            => @this < 0;

        /// <summary>
        /// Returns true if value is a negative number
        /// </summary>
        public static bool Negative(this long @this) 
            => @this < 0;


        /// <summary>
        /// Returns true if value is a negative number
        /// </summary>
        public static bool Negative(this float @this) 
            => @this < 0;

        /// <summary>
        /// Returns true if value is a negative number
        /// </summary>
        public static bool Negative(this double @this) 
            => @this < 0;

        /// <summary>
        /// Returns true if value is a negative number
        /// </summary>
        public static bool Negative(this decimal @this) 
            => @this < 0;
    }
}