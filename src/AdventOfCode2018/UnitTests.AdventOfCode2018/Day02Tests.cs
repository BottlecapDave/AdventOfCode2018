using System;
using AdventOfCode2018;
using Xunit;

namespace UnitTests.AdventOfCode2018
{
    public class Day02Tests
    {
        [Fact]
        public void PartOne_When_ExampleOne_Then_ResultIsTwelve()
        {
            // Arrange
            var eval = new Day02();

            // Act
            var result = eval.PartOne("abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab");

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void PartOne_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day02();

            // Act
            var result = eval.PartOne("TestData/02.txt");

            // Assert
            Assert.Equal(8820, result);
        }

        [Fact]
        public void PartTwo_When_ExampleOne_Then_ResultIsFGIJ()
        {
            // Arrange
            var eval = new Day02();

            // Act
            var result = eval.PartTwo("abcde", "fghij", "klmno", "pqrst", "fguij", "axcye", "wvxyz");

            // Assert
            Assert.Equal("fgij", result);
        }

        [Fact]
        public void PartTwo_When_ExampleOne_Then_ResultIsABCCD()
        {
            // Arrange
            var eval = new Day02();

            // Act
            var result = eval.PartTwo("abcdef", "bababc", "abbcde", "abcccd", "aabcdd", "abcdee", "ababab");

            // Assert
            Assert.Equal("abcde", result);
        }

        [Fact]
        public void PartTwo_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day02();

            // Act
            var result = eval.PartTwo("TestData/02.txt");

            // Assert
            Assert.Equal("bpacnmglhizqygfsjixtkwudr", result);
        }
    }
}
