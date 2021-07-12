using System.Text.Json;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Functions
    {
        #pragma warning disable CS8604
        public static Maybe<T> Clone<T>(this T self)
            => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(self));
    }
}
