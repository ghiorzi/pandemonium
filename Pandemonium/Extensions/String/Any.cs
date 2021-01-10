using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool Any(this string @this, params string[] values)
        {
            foreach (string value in values)
            {
                bool equals = @this.Equals(value);

                if (equals)
                    return true;
            }

            return false;
        }

        public static bool Any(this string @this, StringComparison comparison, params string[] values)
        {
            foreach (string value in values)
            {
                bool equals = @this.Equals(value, comparison);

                if (equals)
                    return true;
            }

            return false;
        }
    }
}