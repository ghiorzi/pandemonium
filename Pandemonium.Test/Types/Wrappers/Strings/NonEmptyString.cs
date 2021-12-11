using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.WrappersStringsTest
{
    public class FromTest
    {
        [Fact]
        public void Should_Create_A_Failable_For_string()
        {
            var value = NonEmptyString.From("ghiorzi");
            var valueWithoutException = NonEmptyString.From("ghiorzi", new Exception("Value must be not be empty"));
            var valueWithException = NonEmptyString.From(string.Empty, new Exception("Value must be not be empty"));

            Assert.True(value.Succeeded);
            Assert.True(valueWithoutException.Succeeded);
            Assert.True(valueWithException.Failed);
        }
    }

}
