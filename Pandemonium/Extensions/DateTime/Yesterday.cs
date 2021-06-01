using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static DateTime Yesterday(this DateTime self)
            => self.AddDays(-1);
    }
}