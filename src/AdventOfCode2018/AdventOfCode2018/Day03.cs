using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2018
{
    public class Day03
    {
        public readonly Regex _regex = new Regex("^#(?<id>\\d+) @ (?<x>\\d+),(?<y>\\d+): (?<width>\\d+)x(?<height>\\d+)$");

        public int PartOne(string filePath)
        {
            var values = File.ReadLines(filePath).ToArray();
            return PartOne(values);
        }

        public int PartOne(params string[] values)
        {
            var gridContent = new Dictionary<KeyValuePair<long, long>, List<long>>();
            var overlappedAreas = new List<KeyValuePair<long, long>>();

            foreach (var value in values)
            {
                var match = _regex.Match(value);
                if (match.Success == false)
                {
                    throw new InvalidDataException($"Unexpected format for '{value}' encountered.");
                }

                var id = Int64.Parse(match.Groups["id"].Value);
                var x = Int64.Parse(match.Groups["x"].Value);
                var y = Int64.Parse(match.Groups["y"].Value);
                var width = Int64.Parse(match.Groups["width"].Value);
                var height = Int64.Parse(match.Groups["height"].Value);

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        var space = new KeyValuePair<long, long>(x + i, y + j);

                        // retrieve our target space and add our id to the collection of patches that have been assigned that space.
                        if (gridContent.TryGetValue(space, out List<long> ids) == false)
                        {
                            ids = new List<long>();
                            gridContent.Add(space, ids);
                        }

                        ids.Add(id);

                        // If we have at least 2 items on our current space, then add the space to our list of overlapped areas
                        if (ids.Count == 2)
                        {
                            overlappedAreas.Add(space);
                        }
                    }
                }
            }

            return overlappedAreas.Count;
        }
    }
}
