using Microsoft.Extensions.DependencyInjection;
using Pandemonium.Configurations;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static Nothing AddPandemonium(
            this IServiceCollection _,
            Exceptions exceptions = null
        )
        {
            Configuration.Setup(exceptions);

            return Nothing.Of();
        }
    }
}