namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool GreaterThan(this sbyte self, sbyte number) 
            => self > number;

        public static bool GreaterThan(this byte self, byte number) 
            => self > number;

        public static bool GreaterThan(this short self, short number) 
            => self > number;

        public static bool GreaterThan(this ushort self, ushort number) 
            => self > number;

        public static bool GreaterThan(this int self, int number) 
            => self > number;

        public static bool GreaterThan(this uint self, uint number) 
            => self > number;

        public static bool GreaterThan(this long self, long number) 
            => self > number;

        public static bool GreaterThan(this ulong self, ulong number) 
            => self > number;

        public static bool GreaterThan(this float self, float number) 
            => self > number;

        public static bool GreaterThan(this double self, double number) 
            => self > number;

        public static bool GreaterThan(this decimal self, decimal number) 
            => self > number;
    }
}