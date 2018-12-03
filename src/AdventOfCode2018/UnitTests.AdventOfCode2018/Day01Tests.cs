using System;
using AdventOfCode2018;
using Xunit;

namespace UnitTests.AdventOfCode2018
{
    public class Day01Tests
    {
        [Fact]
        public void PartOne_When_ExampleOne_Then_ResultIsThree()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartOne(1, 1, 1);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void PartOne_When_ExampleTwo_Then_ResultIsZero()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartOne(1, 1, -2);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void PartOne_When_ExampleThree_Then_ResultIsMinusSix()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartOne(-1, -2, -3);

            // Assert
            Assert.Equal(-6, result);
        }

        [Fact]
        public void PartOne_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartOne("TestData/01.txt");

            // Assert
            Assert.Equal(486, result);
        }

        [Fact]
        public void PartTwo_When_ExampleOne_Then_ResultIsZero()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartTwo(1, -1);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void PartTwo_When_ExampleTwo_Then_ResultIsTen()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartTwo(3, 3, 4, -2, -4);

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void PartTwo_When_ExampleThree_Then_ResultIsFive()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartTwo(-6, 3, 8, 5, -6);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void PartTwo_When_ExampleThree_Then_ResultIsFourteen()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartTwo(7, 7, -2, -7, -4);

            // Assert
            Assert.Equal(14, result);
        }

        [Fact]
        public void PartTwo_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day01();

            // Act
            var result = eval.PartTwo("TestData/01.txt");

            // Assert
            Assert.Equal(69285, result);
        }
    }
}
