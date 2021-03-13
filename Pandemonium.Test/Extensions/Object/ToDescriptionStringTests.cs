using System;
using System.Collections.Generic;
using Xunit;

namespace Pandemonium.Test.Extensions.Object
{
    public class ToDescriptionStringTests
    {
        [Fact]
        public void Should_Return_String_Description_When_Anonymous_Object_Not_Null()
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
        }

        [Fact]
        public void Should_Return_String_Description_When_Class_Object_Not_Null()
        {
            var @object = new SampleClass
            {
                FirstName = "FirstName",
                SecondName = "SecondName"
            };

            string description = @object.ToDescriptionString();
            Assert.NotEmpty(description);
        }

        [Fact]
        public void Should_Return_String_Description_When_Primitive_Object_Not_Null()
        {
            var @object = "Test";

            string description = @object.ToDescriptionString();
            Assert.NotEmpty(description);
        }

        [Fact]
        public void Should_Not_Return_String_Description_When_Object_Is_Null()
        {
            object @object = null;

            string description = @object.ToDescriptionString();
            Assert.Empty(description);
        }
    }

    internal class SampleClass
    {
        public static string StaticValue { get; } = "Static";
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName => $"{FirstName} {SecondName}";
        public object NullValue { get; } = null;
        public DateTime? NullableValue { get; } = DateTime.Now;
    }
}