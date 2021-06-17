namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool EqualTo(this sbyte self, sbyte number) 
            => self == number;

        public static bool EqualTo(this byte self, byte number) 
            => self == number;

        public static bool EqualTo(this short self, short number) 
            => self == number;

        public static bool EqualTo(this ushort self, ushort number) 
            => self == number;

        public static bool EqualTo(this int self, int number) 
            => self == number;

        public static bool EqualTo(this uint self, uint number) 
            => self == number;

        public static bool EqualTo(this long self, long number) 
            => self == number;

        public static bool EqualTo(this ulong self, ulong number) 
            => self == number;

        public static bool EqualTo(this float self, float number) 
            => self == number;

        public static bool EqualTo(this double self, double number) 
            => self == number;

        public static bool EqualTo(this decimal self, decimal number) 
            => self == number;
    }
}