using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2018
{
    public class Day02
    {
        public int PartOne(string filePath)
        {
            var values = File.ReadLines(filePath).ToArray();
            return PartOne(values);
        }

        public int PartOne(params string[] values)
        {
            int numberOfTwoLetters = 0;
            int numberOfThreeLetters = 0;

            foreach (string value in values)
            {
                var characterCount = new Dictionary<char, int>();

                foreach (char character in value)
                {
                    characterCount.TryGetValue(character, out int totalFound);
                    characterCount.Remove(character);

                    totalFound++;
                    characterCount.Add(character, totalFound);
                }

                numberOfTwoLetters += characterCount.Any(x => x.Value == 2) ? 1 : 0;
                numberOfThreeLetters += characterCount.Any(x => x.Value == 3) ? 1 : 0;
            }

            return numberOfTwoLetters * numberOfThreeLetters;
        }


        public string PartTwo(string filePath)
        {
            var values = File.ReadLines(filePath).ToArray();
            return PartTwo(values);
        }

        public string PartTwo(params string[] values)
        {
            foreach (var currentValue in values)
            {
                foreach (var comparisonValue in values)
                {
                    // Skip the value we're currently looking at
                    if (String.Equals(currentValue, comparisonValue, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    if (Compare(currentValue, comparisonValue, out string commonCharacters))
                    {
                        return commonCharacters;
                    }
                }
            }

            return null;
        }

        private bool Compare(string currentValue, string comparisonValue, out string commonCharacters)
        {
            commonCharacters = String.Empty;
            var numberOfUncommonCharacters = 0;
            for (var index = 0; index < currentValue.Length; index++)
            {
                if (comparisonValue[index] == currentValue[index])
                {
                    commonCharacters = $"{commonCharacters}{currentValue[index]}";
                }
                else if (numberOfUncommonCharacters < 1)
                {
                    numberOfUncommonCharacters++;
                }
                else
                {
                    return false;
                }
            }

            return numberOfUncommonCharacters == 1;
        }
    }
}
