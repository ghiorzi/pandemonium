using Xunit;
using System;
using Pandemonium;

namespace Pandemonium.Test.Extensions.Object
{
    public class ToTest
    {
        [Fact]
        public void Should_Cast_When_String_To_Object() 
        {
            string value = "anything";
            object result = value.To<object>();

            Assert.True(result != null);
        }

        [Fact]
        public void Should_Not_Cast_When_Int_To_String() 
        {
            int value = 0;
            var exception = Assert.Throws<InvalidCastException>(() => value.To<string>());
       
            Assert.NotEmpty(exception.Message);
        } 
    }
}
