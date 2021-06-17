using System;
using static Pandemonium.Functions.Composable;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Func<Failable<T>> Compose(params Func<Failable<T>, Failable<T>>[] functions)
        {
            var self = this;

            return () => Compose<Failable<T>>(functions)(self);
        }
    }
}