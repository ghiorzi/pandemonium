using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Between(this DateTime self, DateTime min, DateTime max)
            => min.CompareTo(self) == -1 && self.CompareTo(max) == -1;
    }
}