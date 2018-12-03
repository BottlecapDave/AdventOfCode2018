using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2018
{
    public class Day01
    {
        public int PartOne(string filePath)
        {
            var values = File.ReadLines(filePath).Select(x => Int32.Parse(x)).ToArray();
            return PartOne(values);
        }

        public int PartOne(params int[] numbers)
        {
            return numbers.Aggregate((current, next) => current + next);
        }

        public int PartTwo(string filePath)
        {
            var values = File.ReadLines(filePath).Select(x => Int32.Parse(x)).ToArray();
            return PartTwo(values);
        }

        public int PartTwo(params int[] numbers)
        {
            var discoveredValues = new HashSet<int>();
            var currentValue = 0;
            discoveredValues.Add(currentValue);

            for (; ; )
            {
                foreach (var number in numbers)
                {
                    currentValue += number;

                    if (discoveredValues.Contains(currentValue))
                    {
                        return currentValue;
                    }

                    discoveredValues.Add(currentValue);
                }
            }
        }
    }
}
