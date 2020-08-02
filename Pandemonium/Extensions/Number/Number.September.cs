using System;
using System.Globalization;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        private const sbyte SEPTEMBER = 9;

        public static DateTime September(this int @this, int year) 
            => new DateTime(year, SEPTEMBER, @this);
        
        public static DateTime September(this int @this, int year, Calendar calendar) 
            => new DateTime(year, SEPTEMBER, @this, calendar);

        public static DateTime September(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, SEPTEMBER, @this, hour, minute, second);

        public static DateTime September(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, SEPTEMBER, @this, hour, minute, second, kind);

        public static DateTime September(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, SEPTEMBER, @this, hour, minute, second, calendar);

        public static DateTime September(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, SEPTEMBER, @this, hour, minute, second, millisecond);

        public static DateTime September(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, SEPTEMBER, @this, hour, minute, second, millisecond, kind);
    }
}