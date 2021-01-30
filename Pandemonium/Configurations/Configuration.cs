using Pandemonium.Types;

namespace Pandemonium.Configurations
{
    public static class Configuration
    {
        public static Exceptions Exceptions { get; private set; }

        public static Nothing Setup(Exceptions exceptions)
        {
            Exceptions = exceptions ?? new Exceptions();

            return Nothing.Of();
        }
    }
}