using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static TimeSpan Seconds(this sbyte @this) 
            => TimeSpan.FromSeconds(@this);

        public static TimeSpan Seconds(this short @this) 
            => TimeSpan.FromSeconds(@this);

        public static TimeSpan Seconds(this int @this) 
            => TimeSpan.FromSeconds(@this);

        public static TimeSpan Seconds(this long @this) 
            => TimeSpan.FromSeconds(@this);

        public static TimeSpan Seconds(this float @this) 
            => TimeSpan.FromSeconds(@this);

        public static TimeSpan Seconds(this double @this) 
            => TimeSpan.FromSeconds(@this);
    }
}