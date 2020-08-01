using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
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