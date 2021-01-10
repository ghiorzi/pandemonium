using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static TimeSpan Hours(this sbyte @this) 
            => TimeSpan.FromHours(@this);

        public static TimeSpan Hours(this short @this) 
            => TimeSpan.FromHours(@this);

        public static TimeSpan Hours(this int @this) 
            => TimeSpan.FromHours(@this);

        public static TimeSpan Hours(this long @this) 
            => TimeSpan.FromHours(@this);

        public static TimeSpan Hours(this float @this) 
            => TimeSpan.FromHours(@this);

        public static TimeSpan Hours(this double @this) 
            => TimeSpan.FromHours(@this);
    }
}