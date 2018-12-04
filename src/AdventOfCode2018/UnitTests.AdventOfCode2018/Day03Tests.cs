using System;
using AdventOfCode2018;
using Xunit;

namespace UnitTests.AdventOfCode2018
{
    public class Day03Tests
    {
        [Fact]
        public void PartOne_When_ExampleOne_Then_ResultIsFour()
        {
            // Arrange
            var eval = new Day03();

            // Act
            var result = eval.PartOne("#1 @ 1,3: 4x4", "#2 @ 3,1: 4x4", "#3 @ 5,5: 2x2");

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void PartOne_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day03();

            // Act
            var result = eval.PartOne("TestData/03.txt");

            // Assert
            Assert.Equal(109716, result);
        }

        [Fact]
        public void PartTwo_When_ExampleOne_Then_ResultIsThree()
        {
            // Arrange
            var eval = new Day03();

            // Act
            var result = eval.PartTwo("#1 @ 1,3: 4x4", "#2 @ 3,1: 4x4", "#3 @ 5,5: 2x2");

            // Assert
            Assert.Single(result);
            Assert.Contains(3, result);
        }

        [Fact]
        public void PartTwo_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day03();

            // Act
            var result = eval.PartTwo("TestData/03.txt");

            // Assert
            Assert.Single(result);
            Assert.Contains(124, result);
        }
    }
}
