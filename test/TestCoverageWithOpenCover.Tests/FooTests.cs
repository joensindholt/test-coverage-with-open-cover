using System;
using Xunit;

namespace TestCoverageWithOpenCover.Tests
{
    public class FooTests
    {
        [Fact]
        public void DooFooReturnsConcatenatedStrings()
        {
            // Arrange
            var s1 = "string 1";
            var s2 = "string 2";
            var expectedResult = s1 + s2;

            // Act
            var foo = new Foo();
            var result = foo.DooFoo(s1, s2);

            // Assert
            Assert.Equal(expectedResult, result);   
        }
    }
}
