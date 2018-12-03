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
    }
}
