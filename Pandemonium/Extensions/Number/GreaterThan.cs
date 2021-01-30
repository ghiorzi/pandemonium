namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool GreaterThan(this sbyte @this, sbyte number) 
            => @this > number;

        public static bool GreaterThan(this byte @this, byte number) 
            => @this > number;

        public static bool GreaterThan(this short @this, short number) 
            => @this > number;

        public static bool GreaterThan(this ushort @this, ushort number) 
            => @this > number;

        public static bool GreaterThan(this int @this, int number) 
            => @this > number;

        public static bool GreaterThan(this uint @this, uint number) 
            => @this > number;

        public static bool GreaterThan(this long @this, long number) 
            => @this > number;

        public static bool GreaterThan(this ulong @this, ulong number) 
            => @this > number;

        public static bool GreaterThan(this float @this, float number) 
            => @this > number;

        public static bool GreaterThan(this double @this, double number) 
            => @this > number;

        public static bool GreaterThan(this decimal @this, decimal number) 
            => @this > number;
    }
}