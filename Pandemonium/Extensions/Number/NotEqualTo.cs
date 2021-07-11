namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotEqualTo(this sbyte self, sbyte number) 
            => self != number;

        public static bool NotEqualTo(this byte self, byte number) 
            => self != number;

        public static bool NotEqualTo(this short self, short number) 
            => self != number;

        public static bool NotEqualTo(this ushort self, ushort number) 
            => self != number;

        public static bool NotEqualTo(this int self, int number) 
            => self != number;

        public static bool NotEqualTo(this uint self, uint number) 
            => self != number;

        public static bool NotEqualTo(this long self, long number) 
            => self != number;

        public static bool NotEqualTo(this ulong self, ulong number) 
            => self != number;

        public static bool NotEqualTo(this float self, float number) 
            => self != number;

        public static bool NotEqualTo(this double self, double number) 
            => self != number;

        public static bool NotEqualTo(this decimal self, decimal number) 
            => self != number;
    }
}