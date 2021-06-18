using Xunit;
using System;
using System.Threading.Tasks;
using Pandemonium.Types;

using static Pandemonium.Functions.Composable;
using static Pandemonium.Functions.Doable;

namespace Pandemonium.Test.Functions
{
    public class DoTest
    {

        [Fact]
        public void Should_Do()
        {
            var function =
                Compose(
                    Do<double>(x => {}),
                    Do<double>(() => {}),
                    Do<double>(x => Failable.From(x * x))
                );

            var value = function(10);

            value
                .Match(
                     _ => Assert.Equal(100, _),
                    (_) => throw new Exception("It should not run this block")
                );
        }
    }
}
