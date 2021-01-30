namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotEqualTo(this sbyte @this, sbyte number) 
            => @this != number;

        public static bool NotEqualTo(this byte @this, byte number) 
            => @this != number;

        public static bool NotEqualTo(this short @this, short number) 
            => @this != number;

        public static bool NotEqualTo(this ushort @this, ushort number) 
            => @this != number;

        public static bool NotEqualTo(this int @this, int number) 
            => @this != number;

        public static bool NotEqualTo(this uint @this, uint number) 
            => @this != number;

        public static bool NotEqualTo(this long @this, long number) 
            => @this != number;

        public static bool NotEqualTo(this ulong @this, ulong number) 
            => @this != number;

        public static bool NotEqualTo(this float @this, float number) 
            => @this != number;

        public static bool NotEqualTo(this double @this, double number) 
            => @this != number;

        public static bool NotEqualTo(this decimal @this, decimal number) 
            => @this != number;
    }
}