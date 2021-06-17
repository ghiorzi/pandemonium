using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool Today(this DateTime self) 
            => self.Date == DateTime.Today;
    }
}