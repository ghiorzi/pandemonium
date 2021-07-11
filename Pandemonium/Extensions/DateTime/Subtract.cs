using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static DateTime Subtract(this DateTime self, int days) 
            => self.AddDays(days * -1);
    }
}