using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool Weekday(this DateTime self) 
            => self.Weekend() is false;
    }
}