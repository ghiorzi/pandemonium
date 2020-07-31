namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this sbyte @this, sbyte number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this byte @this, byte number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this short @this, short number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this ushort @this, ushort number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this int @this, int number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this uint @this, uint number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this long @this, long number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this ulong @this, ulong number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this float @this, float number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this double @this, double number) 
            => @this == number;

        /// <summary>
        /// Returns true if value is equal to number
        /// </summary>
        public static bool EqualTo(this decimal @this, decimal number) 
            => @this == number;
    }
}