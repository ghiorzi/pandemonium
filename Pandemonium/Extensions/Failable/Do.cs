using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Func<Failable<T>> Do<T>(this Failable<T> _, Action action)
        {
            return () => 
            {
                if(_.Succeeded)
                    action();

                return _;
            };
        }

        public static Func<Failable<T>> Do<T>(this Failable<T> _, Action<T> action)
        {
            return () => 
            {
                #pragma warning disable CS8604
                if(_.Succeeded)
                    action(_.Value);

                return _;
            };
        }
    }
}