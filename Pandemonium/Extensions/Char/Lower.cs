using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is in lowercase, otherwise returns false
        /// </summary> 
        public static bool Lower(this char self) 
            => Char.IsLower(self);
    }
}