namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool LessThan(this sbyte @this, sbyte number) 
            => @this < number;

        public static bool LessThan(this byte @this, byte number) 
            => @this < number;

        public static bool LessThan(this short @this, short number) 
            => @this < number;

        public static bool LessThan(this ushort @this, ushort number) 
            => @this < number;

        public static bool LessThan(this int @this, int number) 
            => @this < number;

        public static bool LessThan(this uint @this, uint number) 
            => @this < number;

        public static bool LessThan(this long @this, long number) 
            => @this < number;

        public static bool LessThan(this ulong @this, ulong number) 
            => @this < number;

        public static bool LessThan(this float @this, float number) 
            => @this < number;

        public static bool LessThan(this double @this, double number) 
            => @this < number;

        public static bool LessThan(this decimal @this, decimal number) 
            => @this < number;
    }
}