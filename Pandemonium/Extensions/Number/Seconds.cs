using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static TimeSpan Seconds(this sbyte self) 
            => TimeSpan.FromSeconds(self);

        public static TimeSpan Seconds(this short self) 
            => TimeSpan.FromSeconds(self);

        public static TimeSpan Seconds(this int self) 
            => TimeSpan.FromSeconds(self);

        public static TimeSpan Seconds(this long self) 
            => TimeSpan.FromSeconds(self);

        public static TimeSpan Seconds(this float self) 
            => TimeSpan.FromSeconds(self);

        public static TimeSpan Seconds(this double self) 
            => TimeSpan.FromSeconds(self);
    }
}