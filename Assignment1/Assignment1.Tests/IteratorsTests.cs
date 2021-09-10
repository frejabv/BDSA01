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
    }
}
