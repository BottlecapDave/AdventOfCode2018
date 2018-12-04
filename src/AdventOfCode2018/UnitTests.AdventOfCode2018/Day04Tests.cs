using System;
using AdventOfCode2018;
using Xunit;

namespace UnitTests.AdventOfCode2018
{
    public class Day04Tests
    {
        [Fact]
        public void PartOne_When_ExampleOne_Then_ResultIsTwoHundresAndForty()
        {
            // Arrange
            var eval = new Day04();

            // Act
            var result = eval.PartOne("TestData/04.example.txt");

            // Assert
            Assert.Equal(240, result);
        }

        [Fact]
        public void PartOne_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day04();

            // Act
            var result = eval.PartOne("TestData/04.txt");

            // Assert
            Assert.Equal(67558, result);
        }

        [Fact]
        public void PartTwo_When_ExampleOne_Then_ResultIsFourThousandFourHundredAndFiftyFive()
        {
            // Arrange
            var eval = new Day04();

            // Act
            var result = eval.PartTwo("TestData/04.example.txt");

            // Assert
            Assert.Equal(4455, result);
        }

        [Fact]
        public void PartTwo_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day04();

            // Act
            var result = eval.PartTwo("TestData/04.txt");

            // Assert
            Assert.Equal(78990, result);
        }
    }
}
