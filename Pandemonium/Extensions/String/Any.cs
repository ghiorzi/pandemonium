using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Any(this string self, params string[] values)
        {
            foreach (string value in values)
            {
                bool equals = self.Equals(value);

                if (equals)
                    return true;
            }

            return false;
        }

        public static bool Any(this string self, StringComparison comparison, params string[] values)
        {
            foreach (string value in values)
            {
                bool equals = self.Equals(value, comparison);

                if (equals)
                    return true;
            }

            return false;
        }
    }
}