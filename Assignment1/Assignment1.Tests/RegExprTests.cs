using System; 
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
    
        [Fact]
        public void Resolution_given_1_string_of_8_resolutions_returns_8_tuples()
        {
            //Arrange 
            var input = "1920x1080 1024x768, 800x600, 640x480 320x200, 320x240, 800x600 1280x960";
            var expectedOutput = new List<(int, int)>{(1920, 1080), (1024, 768), (800, 600), (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)};

            //Act 
            var output = RegExpr.Resolution(input);


            //Assert
            Assert.Equal(expectedOutput, output); 
        }

    }


}
