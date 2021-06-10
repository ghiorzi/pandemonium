using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.RunTest
{
    public class WhenTest
    {
        [Fact]
        public void Should_Run_Action()
        {
            var action =
                Run
                    .When<int>(x => x > 11)
                    .Do((_) => Assert.Equal(12, _));

            action(12);
        }

        [Fact]
        public void Should_Run_Function()
        {
            var function =
                Run
                    .When<int>(x => x > 11)
                    .Do((_) => _ * _);

            function(12)
                .Match(
                    value: (_) => Assert.Equal(144, _),
                    empty: () => throw new Exception("It should not run this block")
                );
        }
    }

}
