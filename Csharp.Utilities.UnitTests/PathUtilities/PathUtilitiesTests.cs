using Csharp.Utilities.Base.PathUtilities.Exceptions;
using Xunit;

namespace Csharp.Utilities.Tests.PathUtilities
{
    public class PathUtilitiesTests
    {
        [Fact]
        public void PathInvalidDirectorySeparatorTest()
        {
            Assert.Throws<InvalidDirectorySeperatorCharException>(
                () => Base.PathUtilities.PathUtilities.RemoveFolder("/", 1, "\\\\")
                );
        }
        [Fact]
        public void PathTest()
        {
            string input = "/first/second/third/forth/fifth/";
            string expected = "/first/second/";
            string result = Base.PathUtilities.PathUtilities.RemoveFolder(input, 3, "/");
            Assert.Equal(expected, result);
        }
    }
}
