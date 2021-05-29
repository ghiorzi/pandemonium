using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Contains(this string self, string value) 
            => self.IndexOf(value) != -1;

        public static bool Contains(this string self, StringComparison comparison, string value)
            => self.IndexOf(value, comparison) != -1;

        public static bool Contains(this string self, params string[] values)
        {
            foreach (string value in values)
            {
                bool contains = self.IndexOf(value) != -1;

                if (contains)
                    return true;
            }

            return false;
        }

        public static bool Contains(this string self, StringComparison comparison, params string[] values)
        {
            foreach (string value in values)
            {
                bool contains = self.IndexOf(value, comparison) != -1;

                if (contains)
                    return true;
            }

            return false;
        }
    }
}