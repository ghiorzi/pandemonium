using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Func<TSource, bool> Or<TSource>(this Func<TSource, bool> self, params Func<TSource, bool>[] functions) 
        {
            return (TSource value) => 
            {
                bool result = self(value);

                // There is no need to compare other functions
                if (result)
                    return result;

                for (int i = 0; i < functions.Length; i++)
                {
                    result = functions[i](value);

                    // There is no need to compare other functions
                    if (result)
                        break;
                }
               
                return result;
            };
        }
    }
}