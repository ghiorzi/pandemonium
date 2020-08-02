using System;
using System.Globalization;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        private const sbyte AUGUST = 8;

        public static DateTime August(this int @this, int year) 
            => new DateTime(year, AUGUST, @this);
        
        public static DateTime August(this int @this, int year, Calendar calendar) 
            => new DateTime(year, AUGUST, @this, calendar);

        public static DateTime August(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, AUGUST, @this, hour, minute, second);

        public static DateTime August(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, AUGUST, @this, hour, minute, second, kind);

        public static DateTime August(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, AUGUST, @this, hour, minute, second, calendar);

        public static DateTime August(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, AUGUST, @this, hour, minute, second, millisecond);

        public static DateTime August(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, AUGUST, @this, hour, minute, second, millisecond, kind);
    }
}