using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte MARCH = 3;

        public static DateTime March(this int @this, int year) 
            => new DateTime(year, MARCH, @this);
        
        public static DateTime March(this int @this, int year, Calendar calendar) 
            => new DateTime(year, MARCH, @this, calendar);

        public static DateTime March(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, MARCH, @this, hour, minute, second);

        public static DateTime March(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, MARCH, @this, hour, minute, second, kind);

        public static DateTime March(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, MARCH, @this, hour, minute, second, calendar);

        public static DateTime March(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, MARCH, @this, hour, minute, second, millisecond);

        public static DateTime March(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, MARCH, @this, hour, minute, second, millisecond, kind);
    }
}