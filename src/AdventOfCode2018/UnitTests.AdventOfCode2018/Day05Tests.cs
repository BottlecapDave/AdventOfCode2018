﻿using System;
using AdventOfCode2018;
using Xunit;

namespace UnitTests.AdventOfCode2018
{
    public class Day05Tests
    {
        [Fact]
        public void PartOne_When_ExampleOne_Then_ResultIsExampleAnswer()
        {
            // Arrange
            var eval = new Day05();

            // Act
            var result = eval.PartOne("dabAcCaCBAcCcaDA");

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void PartOne_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day05();

            // Act
            var result = eval.PartOneWithFile("TestData/05.txt");

            // Assert
            Assert.Equal(9370, result);
        }

        [Fact]
        public void PartTwo_When_ExampleOne_Then_ResultIsExampleAnswer()
        {
            // Arrange
            var eval = new Day05();

            // Act
            var result = eval.PartTwo("dabAcCaCBAcCcaDA");

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void PartTwo_When_ExampleFile_Then_ResultIsAnswer()
        {
            // Arrange
            var eval = new Day05();

            // Act
            var result = eval.PartTwoWithFile("TestData/05.txt");

            // Assert
            Assert.Equal(6390, result);
        }
    }
}
