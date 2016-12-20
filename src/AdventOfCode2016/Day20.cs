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
        public List<uint> AllowedIPs = new List<uint>();

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
            BlockedIPs.Sort(CompareRanges);
        }

        /// Count all the blocked IPs and then remove then from all available IPs
        /// The list of ranges needs to be sorted by lower bound
        public long GetAllAllowedIPs () {
            long countBlockedIPs = 0;
            long min = BlockedIPs[0].LowerBound;
            long max = BlockedIPs[0].HigherBound;
            foreach (var range in BlockedIPs) {
                if (range.LowerBound > max + 1) {
                    countBlockedIPs += max - min + 1;
                    min = range.LowerBound;
                    max = range.HigherBound;
                } else {
                    max = Math.Max(max, range.HigherBound);
                }
            }
            countBlockedIPs += max - min + 1;
            return 4294967296 - countBlockedIPs;
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

        private static int CompareRanges(Range r1, Range r2) {
            if (r1.LowerBound < r2.LowerBound) {
                return -1;
            } 
            else {
                return 1;
            }
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
