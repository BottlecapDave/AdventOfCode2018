using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2018
{
    public class Day04
    {
        private class ShiftEvent
        {
            public DateTime Timestamp { get; set; }

            public EventType Type { get; set; }

            public long? GuardId { get;  set;}
        }

        private class SleepingPattern
        {
            public long GuardId { get; set; }

            public long[] TimesPerMinute { get; set; }

            public long TotalMinutes { get; set; }

            public SleepingPattern(long guardId)
            {
                GuardId = guardId;
                TimesPerMinute = new long[60];
            }
        }

        private enum EventType
        {
            ShiftStart,
            FellAsleep,
            WokeUp
        }

        public readonly Regex _beginShiftRegex = new Regex("^\\[(?<time>[^\\]]+)\\] Guard #(?<id>\\d+) begins shift$");
        public readonly Regex _fallsAsleepShiftRegex = new Regex("^\\[(?<time>[^\\]]+)\\] falls asleep$");
        public readonly Regex _wakesUpShiftRegex = new Regex("^\\[(?<time>[^\\]]+)\\] wakes up$");

        public long PartOne(string filePath)
        {
            var values = File.ReadLines(filePath).ToArray();
            return PartOne(values);
        }

        public long PartOne(params string[] values)
        {
            var events = ProcessEvents(values);

            var guardAsleepDictionary = new Dictionary<long, SleepingPattern>();
            long? currentGuardId = null;
            DateTime? currentFellAsleep = null;

            foreach (var shiftEvent in events)
            {
                switch (shiftEvent.Type)
                {
                    case EventType.ShiftStart:
                        currentGuardId = shiftEvent.GuardId;
                        break;
                    case EventType.FellAsleep:
                        currentFellAsleep = shiftEvent.Timestamp;
                        break;
                    case EventType.WokeUp:

                        if (guardAsleepDictionary.TryGetValue(currentGuardId.Value, out SleepingPattern pattern) == false)
                        {
                            pattern = new SleepingPattern(currentGuardId.Value);
                            guardAsleepDictionary.Add(currentGuardId.Value, pattern);
                        }

                        var totalMinutes = 0;
                        while (currentFellAsleep < shiftEvent.Timestamp)
                        {
                            pattern.TimesPerMinute[currentFellAsleep.Value.Minute]++;
                            currentFellAsleep = currentFellAsleep.Value.AddMinutes(1);
                            totalMinutes++;
                        }

                        pattern.TotalMinutes += totalMinutes;
                        break;
                }

            }

            // Find our star guard and see which day would be best
            var targetGuard = guardAsleepDictionary.Values.OrderByDescending(x => x.TotalMinutes).FirstOrDefault();

            long maxMinutes = 0;
            var targetMinute = 0;
            for (var i = 0; i < targetGuard.TimesPerMinute.Length; i++)
            {
                if (targetGuard.TimesPerMinute[i] > maxMinutes)
                {
                    maxMinutes = targetGuard.TimesPerMinute[i];
                    targetMinute = i;
                }
            }

            return targetMinute * targetGuard.GuardId;
        }

        private IEnumerable<ShiftEvent> ProcessEvents(string[] values)
        {
            var events = new List<ShiftEvent>();

            foreach (var value in values)
            {
                var match = _beginShiftRegex.Match(value);
                if (match.Success)
                {
                    var timestamp = DateTime.Parse(match.Groups["time"].Value);
                    var guardId = Int64.Parse(match.Groups["id"].Value);
                    events.Add(new ShiftEvent()
                    {
                        GuardId = guardId,
                        Timestamp = timestamp,
                        Type = EventType.ShiftStart
                    });

                    continue;
                }

                match = _fallsAsleepShiftRegex.Match(value);
                if (match.Success)
                {
                    var timestamp = DateTime.Parse(match.Groups["time"].Value);
                    events.Add(new ShiftEvent()
                    {
                        Timestamp = timestamp,
                        Type = EventType.FellAsleep
                    });

                    continue;
                }

                match = _wakesUpShiftRegex.Match(value);
                if (match.Success)
                {
                    var timestamp = DateTime.Parse(match.Groups["time"].Value);
                    events.Add(new ShiftEvent()
                    {
                        Timestamp = timestamp,
                        Type = EventType.WokeUp
                    });

                    continue;
                }

            }

            events.Sort((first, second) => first.Timestamp.CompareTo(second.Timestamp));

            return events;
        }
    }
}
