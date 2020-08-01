using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static TimeSpan Milliseconds(this sbyte @this) 
            => TimeSpan.FromMilliseconds(@this);

        public static TimeSpan Milliseconds(this short @this) 
            => TimeSpan.FromMilliseconds(@this);

        public static TimeSpan Milliseconds(this int @this) 
            => TimeSpan.FromMilliseconds(@this);

        public static TimeSpan Milliseconds(this long @this) 
            => TimeSpan.FromMilliseconds(@this);

        public static TimeSpan Milliseconds(this float @this) 
            => TimeSpan.FromMilliseconds(@this);

        public static TimeSpan Milliseconds(this double @this) 
            => TimeSpan.FromMilliseconds(@this);
    }
}