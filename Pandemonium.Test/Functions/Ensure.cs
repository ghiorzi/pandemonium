using Xunit;
using System;
using System.Threading.Tasks;
using Pandemonium.Types;

using static Pandemonium.Functions.Composable;
using static Pandemonium.Functions.Ensureable;

namespace Pandemonium.Test.Functions.EnsureTest
{
    public class EnsureTest
    {
        private readonly Func<int, Task<bool>> _even = async x => await Task.FromResult(x % 2 == 0);
        private readonly Func<int, Task<bool>> _lessThan10 = async x => await Task.FromResult(x < 10);
        private readonly Func<int, Task<bool>> _greaterThan5 = async x => await Task.FromResult(x > 5);

        [Fact]
        public void Should_Be_A_Tautology()
        {
            var function =
                Compose(
                    Ensure<int>(x => x % 2 == 0),
                    Ensure<int>(x => x < 10),
                    Ensure<int>(x => x > 5)
                );

            var value = function(8);

            Assert.True(value.Succeeded);
        }

        [Fact]
        public void Should_Be_A_Contingency()
        {
            var function =
                Compose(
                    Ensure<int>(x => x % 2 == 0),
                    Ensure<int>(x => x < 10),
                    Ensure<int>(x => x > 5)
                );

            var value = function(7);

            Assert.True(value.Failed);
        }
    }
}
