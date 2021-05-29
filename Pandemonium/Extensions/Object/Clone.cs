using System.Text.Json;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static T Clone<T>(this T self)
            => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(self));
    }
}
