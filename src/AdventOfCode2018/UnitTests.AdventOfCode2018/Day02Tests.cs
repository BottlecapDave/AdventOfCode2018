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
    }
}
