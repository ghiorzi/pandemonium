using System;
using System.Linq;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static string Where(this string self, Func<char, bool> predicate)
        {
            char[] value = self.ToCharArray();

            return new string(value.Where(predicate).ToArray());
        }
    }
}