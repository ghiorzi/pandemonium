using Xunit;
using Pandemonium.Types;
using System;

namespace Pandemonium.Test.Types.WrappersNumberTest
{
    public class FromTest
    {
        [Fact]
        public void Should_Create_A_Failable_For_sbyte()
        {
            var value = NonNegativeNumber.From((sbyte) 1);
            var valueWithoutException = NonNegativeNumber.From((sbyte) 1, new Exception("Value must be a positive number"));
            var valueWithException = NonNegativeNumber.From((sbyte) -1, new Exception("Value must be a positive number"));

            Assert.True(value.Succeeded);
            Assert.True(valueWithoutException.Succeeded);
            Assert.True(valueWithException.Failed);
        }

        [Fact]
        public void Should_Create_A_Failable_For_short()
        {
            var value = NonNegativeNumber.From((short) 1);
            var valueWithoutException = NonNegativeNumber.From((short) 1, new Exception("Value must be a positive number"));
            var valueWithException = NonNegativeNumber.From((short) -1, new Exception("Value must be a positive number"));

            Assert.True(value.Succeeded);
            Assert.True(valueWithoutException.Succeeded);
            Assert.True(valueWithException.Failed);
        }
    
        [Fact]
        public void Should_Create_A_Failable_For_int()
        {
            var value = NonNegativeNumber.From((int) 1);
            var valueWithoutException = NonNegativeNumber.From((int) 1, new Exception("Value must be a positive number"));
            var valueWithException = NonNegativeNumber.From((int) -1, new Exception("Value must be a positive number"));

            Assert.True(value.Succeeded);
            Assert.True(valueWithoutException.Succeeded);
            Assert.True(valueWithException.Failed);
        }
    
        [Fact]
        public void Should_Create_A_Failable_For_long()
        {
            var value = NonNegativeNumber.From((long) 1);
            var valueWithoutException = NonNegativeNumber.From((long) 1, new Exception("Value must be a positive number"));
            var valueWithException = NonNegativeNumber.From((long) -1, new Exception("Value must be a positive number"));

            Assert.True(value.Succeeded);
            Assert.True(valueWithoutException.Succeeded);
            Assert.True(valueWithException.Failed);
        }
    
        [Fact]
        public void Should_Create_A_Failable_For_float()
        {
            var value = NonNegativeNumber.From((float) 1);
            var valueWithoutException = NonNegativeNumber.From((float) 1, new Exception("Value must be a positive number"));
            var valueWithException = NonNegativeNumber.From((float) -1, new Exception("Value must be a positive number"));

            Assert.True(value.Succeeded);
            Assert.True(valueWithoutException.Succeeded);
            Assert.True(valueWithException.Failed);
        }

        [Fact]
        public void Should_Create_A_Failable_For_double()
        {
            var value = NonNegativeNumber.From((double) 1);
            var valueWithoutException = NonNegativeNumber.From((double) 1, new Exception("Value must be a positive number"));
            var valueWithException = NonNegativeNumber.From((double) -1, new Exception("Value must be a positive number"));

            Assert.True(value.Succeeded);
            Assert.True(valueWithoutException.Succeeded);
            Assert.True(valueWithException.Failed);
        }

        [Fact]
        public void Should_Create_A_Failable_For_decimal()
        {
            var value = NonNegativeNumber.From((decimal) 1);
            var valueWithoutException = NonNegativeNumber.From((decimal) 1, new Exception("Value must be a positive number"));
            var valueWithException = NonNegativeNumber.From((decimal) -1, new Exception("Value must be a positive number"));

            Assert.True(value.Succeeded);
            Assert.True(valueWithoutException.Succeeded);
            Assert.True(valueWithException.Failed);
        }
    }

}
