namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is a negative number
        /// </summary>
        public static bool Negative(this sbyte self) 
            => self < 0;

        /// <summary>
        /// It returns true if value is a negative number
        /// </summary>
        public static bool Negative(this short self) 
            => self < 0;

        /// <summary>
        /// It returns true if value is a negative number
        /// </summary>
        public static bool Negative(this int self) 
            => self < 0;

        /// <summary>
        /// It returns true if value is a negative number
        /// </summary>
        public static bool Negative(this long self) 
            => self < 0;


        /// <summary>
        /// It returns true if value is a negative number
        /// </summary>
        public static bool Negative(this float self) 
            => self < 0;

        /// <summary>
        /// It returns true if value is a negative number
        /// </summary>
        public static bool Negative(this double self) 
            => self < 0;

        /// <summary>
        /// It returns true if value is a negative number
        /// </summary>
        public static bool Negative(this decimal self) 
            => self < 0;
    }
}