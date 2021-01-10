namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool GreaterThanOrEqualTo(this sbyte @this, sbyte number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this byte @this, byte number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this short @this, short number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this ushort @this, ushort number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this int @this, int number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this uint @this, uint number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this long @this, long number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this ulong @this, ulong number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this float @this, float number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this double @this, double number) 
            => @this >= number;

        public static bool GreaterThanOrEqualTo(this decimal @this, decimal number) 
            => @this >= number;
    }
}