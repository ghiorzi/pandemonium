using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte JANUARY = 1;

        public static DateTime January(this int @this, int year) 
            => new DateTime(year, JANUARY, @this);
        
        public static DateTime January(this int @this, int year, Calendar calendar) 
            => new DateTime(year, JANUARY, @this, calendar);

        public static DateTime January(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, JANUARY, @this, hour, minute, second);

        public static DateTime January(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, JANUARY, @this, hour, minute, second, kind);

        public static DateTime January(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, JANUARY, @this, hour, minute, second, calendar);

        public static DateTime January(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, JANUARY, @this, hour, minute, second, millisecond);

        public static DateTime January(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, JANUARY, @this, hour, minute, second, millisecond, kind);
    }
}