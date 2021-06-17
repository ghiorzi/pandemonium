using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static DateTime Tomorrow(this DateTime self) 
            => self.AddDays(1);
    }
}