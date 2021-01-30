namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool LessThanOrEqualTo(this sbyte @this, sbyte number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this byte @this, byte number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this short @this, short number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this ushort @this, ushort number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this int @this, int number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this uint @this, uint number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this long @this, long number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this ulong @this, ulong number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this float @this, float number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this double @this, double number) 
            => @this <= number;

        public static bool LessThanOrEqualTo(this decimal @this, decimal number) 
            => @this <= number;
    }
}