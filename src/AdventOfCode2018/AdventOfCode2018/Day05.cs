using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2018
{
    public class Day05
    {
        public long PartOneWithFile(string filePath)
        {
            var value = File.ReadAllText(filePath);
            return PartOne(value.Trim());
        }

        public long PartOne(string value)
        {
            var currentCharacters = new Stack<char>();
            foreach (var character in value)
            {
                var lastCharacter = currentCharacters.Count > 0 ? (char?)currentCharacters.Peek() : null;
                if (lastCharacter.HasValue &&
                    Char.ToUpper(character) == Char.ToUpper(lastCharacter.Value) &&
                    ((Char.IsUpper(character) && Char.IsLower(lastCharacter.Value)) ||
                     (Char.IsLower(character) && Char.IsUpper(lastCharacter.Value))))
                {
                    currentCharacters.Pop();
                }
                else
                {
                    currentCharacters.Push(character);
                }
            }

            return currentCharacters.Count;
        }
    }
}
