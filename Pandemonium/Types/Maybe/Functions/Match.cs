using System;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public Nothing Match(Action<T> value, Action empty)
        {
            if (HasValue)
                value(_value);
            else 
                empty();
            
            return Nothing.Of();
        }
    }
}