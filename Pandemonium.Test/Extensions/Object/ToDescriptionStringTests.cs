using System;
using System.Collections.Generic;
using Xunit;

namespace Pandemonium.Test.Extensions.Object
{
    public class ToDescriptionStringTests
    {
        [Fact]
        public void Should_Return_String_Description_When_Object_Not_Null()
        {
            var @object = new
            {
                Name = "Flano",
                Age = 20,
                BirthDate = new DateTime(1990, 01, 01),
                Contacts = new List<string>
                {
                    "(84) 2654-8862",
                    "(84) 2654-8862"
                }
            };

            string description = @object.ToDescriptionString();
            Assert.NotEmpty(description);
            Console.WriteLine(description);
        }
    }
}