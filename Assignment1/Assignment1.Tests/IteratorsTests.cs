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
        public void Flatten_varying_list_length_return_all_Ts_in_one_line()
        {
            // Arrange
            var list1 = new List<char>{'T','T','T'};
            var list2 = new List<char>{'T','T'};
            var list3 = new List<char>{'T','T','T','T'};
            var lists = new List<List<char>>{list1,list2,list3};

            var expectedList = new List<char>{'T','T','T','T','T','T','T','T','T'};

            // Act
            var output = Iterators.Flatten(lists);

            // Assert
            Assert.Equal(expectedList, output);
        }
        [Fact]
        public void Flatten_line_from_shrek()
        {
            // Arrange
            var list1 = new List<string>{"What","are","you"};
            var list2 = new List<string>{"doing","in"};
            var list3 = new List<string>{"my","swamp"};
            var lists = new List<List<string>>{list1,list2,list3};

            var expectedList = new List<string>{"What", "are", "you", "doing", "in", "my", "swamp"};

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
        [Fact]
        public void Filter_insert_odd_numbers_only_return_empty_list()
        {
            // Arrange
            var input = new List<int>{1,3,5,7};
            var expectedOutput = new List<int>{};
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
