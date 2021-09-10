using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void given2LinesReturns6words() {
            // Arrange
            var firstLine = "jeg er mikki";
            var secondLine = "mikki er jeg";
            var input = new List<string> {firstLine, secondLine};

            var expectedOutput = new List<string> {"jeg", "er", "mikki", "mikki", "er", "jeg"};

            // Act
            var output = RegExpr.SplitLine(input);

            // Assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
