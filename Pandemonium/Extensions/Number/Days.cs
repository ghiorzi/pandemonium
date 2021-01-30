using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static TimeSpan Days(this sbyte @this) 
            => TimeSpan.FromDays(@this);

        public static TimeSpan Days(this short @this) 
            => TimeSpan.FromDays(@this);

        public static TimeSpan Days(this int @this) 
            => TimeSpan.FromDays(@this);

        public static TimeSpan Days(this long @this) 
            => TimeSpan.FromDays(@this);

        public static TimeSpan Days(this float @this) 
            => TimeSpan.FromDays(@this);

        public static TimeSpan Days(this double @this) 
            => TimeSpan.FromDays(@this);
    }
}