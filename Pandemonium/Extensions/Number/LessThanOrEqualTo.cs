namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool LessThanOrEqualTo(this sbyte self, sbyte number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this byte self, byte number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this short self, short number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this ushort self, ushort number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this int self, int number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this uint self, uint number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this long self, long number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this ulong self, ulong number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this float self, float number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this double self, double number) 
            => self <= number;

        public static bool LessThanOrEqualTo(this decimal self, decimal number) 
            => self <= number;
    }
}