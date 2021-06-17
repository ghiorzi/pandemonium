using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static TimeSpan Hours(this sbyte self) 
            => TimeSpan.FromHours(self);

        public static TimeSpan Hours(this short self) 
            => TimeSpan.FromHours(self);

        public static TimeSpan Hours(this int self) 
            => TimeSpan.FromHours(self);

        public static TimeSpan Hours(this long self) 
            => TimeSpan.FromHours(self);

        public static TimeSpan Hours(this float self) 
            => TimeSpan.FromHours(self);

        public static TimeSpan Hours(this double self) 
            => TimeSpan.FromHours(self);
    }
}