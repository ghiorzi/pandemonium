namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool EqualTo(this sbyte @this, sbyte number) 
            => @this == number;

        public static bool EqualTo(this byte @this, byte number) 
            => @this == number;

        public static bool EqualTo(this short @this, short number) 
            => @this == number;

        public static bool EqualTo(this ushort @this, ushort number) 
            => @this == number;

        public static bool EqualTo(this int @this, int number) 
            => @this == number;

        public static bool EqualTo(this uint @this, uint number) 
            => @this == number;

        public static bool EqualTo(this long @this, long number) 
            => @this == number;

        public static bool EqualTo(this ulong @this, ulong number) 
            => @this == number;

        public static bool EqualTo(this float @this, float number) 
            => @this == number;

        public static bool EqualTo(this double @this, double number) 
            => @this == number;

        public static bool EqualTo(this decimal @this, decimal number) 
            => @this == number;
    }
}