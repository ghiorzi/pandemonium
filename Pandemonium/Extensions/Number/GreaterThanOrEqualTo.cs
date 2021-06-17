namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool GreaterThanOrEqualTo(this sbyte self, sbyte number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this byte self, byte number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this short self, short number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this ushort self, ushort number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this int self, int number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this uint self, uint number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this long self, long number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this ulong self, ulong number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this float self, float number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this double self, double number) 
            => self >= number;

        public static bool GreaterThanOrEqualTo(this decimal self, decimal number) 
            => self >= number;
    }
}