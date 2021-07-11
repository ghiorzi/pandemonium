using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Weekday(this DateTime self) 
            => self.Weekend() is false;
    }
}