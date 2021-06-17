using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static TimeSpan Milliseconds(this sbyte self) 
            => TimeSpan.FromMilliseconds(self);

        public static TimeSpan Milliseconds(this short self) 
            => TimeSpan.FromMilliseconds(self);

        public static TimeSpan Milliseconds(this int self) 
            => TimeSpan.FromMilliseconds(self);

        public static TimeSpan Milliseconds(this long self) 
            => TimeSpan.FromMilliseconds(self);

        public static TimeSpan Milliseconds(this float self) 
            => TimeSpan.FromMilliseconds(self);

        public static TimeSpan Milliseconds(this double self) 
            => TimeSpan.FromMilliseconds(self);
    }
}