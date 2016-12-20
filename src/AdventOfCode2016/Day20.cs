using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day20
    {
        public string Input;
        public List<Range> BlockedIPs = new List<Range>();

        public Day20(string input)
        {
            Input = input;
            ParseBlockedIPRanges();
        }

        private void ParseBlockedIPRanges () {
            var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (!String.IsNullOrEmpty(line)) {
                    var ranges = line.Split('-');
                    uint low = 0;
                    UInt32.TryParse(ranges[0], out low);
                    uint high = 0;
                    UInt32.TryParse(ranges[1], out high);
                    BlockedIPs.Add(new Range(low, high));
                }
            }
        }

        public uint GetLowestValuedOFNotBlockedIPs () {
            uint lowestIP = 0;
            uint currentTestedIP = 0;
            while (true) {
                foreach (var range in BlockedIPs) {
                    if (currentTestedIP >= range.LowerBound && currentTestedIP <= range.HigherBound) {
                        lowestIP = range.HigherBound + 1;
                    }
                }
                if (lowestIP == currentTestedIP) {
                    break;
                }
                currentTestedIP = lowestIP;
            }
            return lowestIP;
        }

    }

    public class Range {
        public uint LowerBound = 0;
        public uint HigherBound = 0;

        public Range (uint low, uint high) {
            LowerBound = low;
            HigherBound = high;
        }
    }
}
