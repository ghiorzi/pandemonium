using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static bool Contains(this string @this, string value) 
            => @this.IndexOf(value) != -1;

        public static bool Contains(this string @this, StringComparison comparison, string value)
            => @this.IndexOf(value, comparison) != -1;

        public static bool Contains(this string @this, params string[] values)
        {
            foreach (string value in values)
            {
                bool contains = @this.IndexOf(value) != -1;

                if (contains)
                    return true;
            }

            return false;
        }

        public static bool Contains(this string @this, StringComparison comparison, params string[] values)
        {
            foreach (string value in values)
            {
                bool contains = @this.IndexOf(value, comparison) != -1;

                if (contains)
                    return true;
            }

            return false;
        }
    }
}