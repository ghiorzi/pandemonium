using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static TimeSpan Minutes(this sbyte @this) 
            => TimeSpan.FromMinutes(@this);

        public static TimeSpan Minutes(this short @this) 
            => TimeSpan.FromMinutes(@this);

        public static TimeSpan Minutes(this int @this) 
            => TimeSpan.FromMinutes(@this);

        public static TimeSpan Minutes(this long @this) 
            => TimeSpan.FromMinutes(@this);

        public static TimeSpan Minutes(this float @this) 
            => TimeSpan.FromMinutes(@this);

        public static TimeSpan Minutes(this double @this) 
            => TimeSpan.FromMinutes(@this);
    }
}