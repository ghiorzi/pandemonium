namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool LessThan(this sbyte self, sbyte number) 
            => self < number;

        public static bool LessThan(this byte self, byte number) 
            => self < number;

        public static bool LessThan(this short self, short number) 
            => self < number;

        public static bool LessThan(this ushort self, ushort number) 
            => self < number;

        public static bool LessThan(this int self, int number) 
            => self < number;

        public static bool LessThan(this uint self, uint number) 
            => self < number;

        public static bool LessThan(this long self, long number) 
            => self < number;

        public static bool LessThan(this ulong self, ulong number) 
            => self < number;

        public static bool LessThan(this float self, float number) 
            => self < number;

        public static bool LessThan(this double self, double number) 
            => self < number;

        public static bool LessThan(this decimal self, decimal number) 
            => self < number;
    }
}