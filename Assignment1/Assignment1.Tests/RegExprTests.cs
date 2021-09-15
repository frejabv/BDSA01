using System.Collections;
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
        public void Resolution_given_4_strings_of_8_resolutions_returns_8_tuples()
        {
            //Arrange 
            var input = new List<string>{"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};
            var expectedOutput = new List<(int, int)>{(1920, 1080), (1024, 768), (800, 600), (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)};

            //Act 
            var output = RegExpr.Resolution(input);

            //Assert
            Assert.Equal(expectedOutput, output); 
        }

        [Fact] 
        public void Resolution_given_3_strings_of_5_resolutions_returns_5_tuples()
        {
            //Arrange 
            var input = new List<string>{"2784x274", "28473x9274", "284x2422, 9472x243,1957x2922"};
            var expectedOutput = new List<(int, int)>{(2784,274), (28473,9274), (284,2422), (9472,243),(1957,2922)};

            //Act 
            var output = RegExpr.Resolution(input);

            //Assert
            Assert.Equal(expectedOutput, output); 
        }

        [Fact] 
        public void Resolution_given_2_wrong_input_format_returns_3_tuples()
        {
            //Arrange 
            var input = new List<string>{"2784xxxx274", "\n284x", "284x2422,9472x243,,,,,,,,,1957x2922"};
            var expectedOutput = new List<(int, int)>{(284,2422), (9472,243), (1957,2922)};

            //Act 
            var output = RegExpr.Resolution(input);

            //Assert
            Assert.Equal(expectedOutput, output); 
        }

    
        [Fact]
        public void InnerText_given_sample_string_from_assignment_returns_only_content_of_a_tags()
        {
            //Arrange
            var input = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
            var expectedOutput = new List<string>{"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"};

            //Act
            var output = RegExpr.InnerText(input, "a");


            //Assert
            Assert.Equal(expectedOutput, output);
        }


        [Fact]
        public void InnerText_given_nested_sample_html_returns_all_innertext_without_tags()
        {
            //Arrange
            var input = "<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p></div>";
            var expectedOutput = new List<string>{"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};

            //Act
            var output = RegExpr.InnerText(input, "p");

            //Assert
            Assert.Equal(expectedOutput, output);
        }
    
    }


}
