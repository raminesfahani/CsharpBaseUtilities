using Csharp.Utilities.Base.Extensions.Object;
using Csharp.Utilities.Base.Tests;
using Xunit;
using Xunit.Abstractions;

namespace Csharp.Utilities.Tests.Extensions
{
    public class GetQueryStringReflectionTests : TestBase
    {
        public GetQueryStringReflectionTests(ITestOutputHelper outputHelper) : base(outputHelper) { }

        [Fact]
        public void GetQueryStringTest()
        {
            const string expected = "Name=John+Doe&PropertyInt=1&Value=Value_123!%40%23%24%25%5E%26*()";
            TestObject testObject = new TestObject()
            {
                Name = "John Doe",
                PropertyInt = 1,
                PropertyNull = null,
                Value = "Value_123!@#$%^&*()"
            };

            string resultOriginal = testObject.GetQueryString();
            Output.WriteLine(@$"Input: ""{testObject.ToString()}""" + "\n" +
                @$"Result: ""{resultOriginal}""" + "\n" +
                $@"Expected: ""{expected}""");

            Assert.Equal(expected, resultOriginal);
        }

        [Fact]
        public void GetQueryStringToSnakeTest()
        {
            const string expected = "name=John+Doe&property_int=1&value=Value_123!%40%23%24%25%5E%26*()";
            TestObject testObject = new TestObject()
            {
                Name = "John Doe",
                PropertyInt = 1,
                PropertyNull = null,
                Value = "Value_123!@#$%^&*()"
            };

            string resultOriginal = testObject.GetQueryString(SelectCase.PascalToSnakeCase);
            Output.WriteLine(@$"Input: ""{testObject.ToString()}""" + "\n" +
                @$"Result: ""{resultOriginal}""" + "\n" +
                $@"Expected: ""{expected}""");

            Assert.Equal(expected, resultOriginal);
        }
    }

    public class TestObject
    {
        public string Name { get; set; }
        public int PropertyInt { get; set; }
        public string PropertyNull { get; set; }
        public string Value { get; set; }

        public new string ToString()
        {
            return $"Name: {Name} " +
                $"Property: {PropertyInt} " +
                $"PropertyNull: {PropertyNull} " +
                $"Value: {Value}";
        }
    }
}