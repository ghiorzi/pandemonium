using Xunit;
using System;
using System.Threading.Tasks;
using Pandemonium.Types;

using static Pandemonium.Functions.Composable;
using static Pandemonium.Functions.Whereable;

namespace Pandemonium.Test.Functions
{
    public class WhereTest
    {
        [Fact]
        public void Should_Be_A_Tautology()
        {
            var function =
                Compose(
                    Where<int>(x => x % 2 == 0),
                    Where<int>(x => x < 10),
                    Where<int>(x => x > 5)
                );

            var value = function(8);

            Assert.True(value.Succeeded);
        }

        [Fact]
        public void Should_Be_A_Contingency()
        {
            var function =
                Compose(
                    Where<int>(x => x % 2 == 0, new Exception("Number must be even")),
                    Where<int>(x => x < 10),
                    Where<int>(x => x > 5)
                );

            var value = function(7);

            Assert.True(value.Failed);
        }
    }
}
