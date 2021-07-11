using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static TimeSpan Minutes(this sbyte self) 
            => TimeSpan.FromMinutes(self);

        public static TimeSpan Minutes(this short self) 
            => TimeSpan.FromMinutes(self);

        public static TimeSpan Minutes(this int self) 
            => TimeSpan.FromMinutes(self);

        public static TimeSpan Minutes(this long self) 
            => TimeSpan.FromMinutes(self);

        public static TimeSpan Minutes(this float self) 
            => TimeSpan.FromMinutes(self);

        public static TimeSpan Minutes(this double self) 
            => TimeSpan.FromMinutes(self);
    }
}