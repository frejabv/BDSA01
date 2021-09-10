using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_get2by2T_return4T() 
        {
            // Arrange
            var list1 = new List<char>{'T','T'};
            var list2 = new List<char>{'T','T'};
            var lists = new List<List<char>>{list1,list2};

            var expectedList = new List<char>{'T','T','T','T'};

            // Act
            var output = Iterators.Flatten(lists);

            // Assert
            Assert.Equal(expectedList, output);
        }

        [Fact]
        public void Filter_get_1_2_3_4_andEvenPredicateReturn_2_4()
        {
            // Arrange
            var input = new List<int>{1,2,3,4};
            var expectedOutput = new List<int>{2,4};
            Predicate<int> even = Even;

            // Act
            var output = Iterators.Filter(input, Even);

            // Assert
            Assert.Equal(expectedOutput, output);
        } 

        public static bool Even(int i)
        {
            return i % 2 == 0;
        }
    }
}
