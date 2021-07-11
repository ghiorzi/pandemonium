using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static TimeSpan Days(this sbyte self) 
            => TimeSpan.FromDays(self);

        public static TimeSpan Days(this short self) 
            => TimeSpan.FromDays(self);

        public static TimeSpan Days(this int self) 
            => TimeSpan.FromDays(self);

        public static TimeSpan Days(this long self) 
            => TimeSpan.FromDays(self);

        public static TimeSpan Days(this float self) 
            => TimeSpan.FromDays(self);

        public static TimeSpan Days(this double self) 
            => TimeSpan.FromDays(self);
    }
}