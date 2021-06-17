namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// It returns true if value is a positive number
        /// </summary>
        public static bool Positive(this sbyte self) 
            => self > 0;

        /// <summary>
        /// It returns true if value is a positive number
        /// </summary>
        public static bool Positive(this short self) 
            => self > 0;

        /// <summary>
        /// It returns true if value is a positive number
        /// </summary>
        public static bool Positive(this int self) 
            => self > 0;

        /// <summary>
        /// It returns true if value is a positive number
        /// </summary>
        public static bool Positive(this long self) 
            => self > 0;

        /// <summary>
        /// It returns true if value is a positive number
        /// </summary>
        public static bool Positive(this float self) 
            => self > 0;

        /// <summary>
        /// It returns true if value is a positive number
        /// </summary>
        public static bool Positive(this double self) 
            => self > 0;

        /// <summary>
        /// It returns true if value is a positive number
        /// </summary>
        public static bool Positive(this decimal self) 
            => self > 0;
    }
}