using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode1016
{
    public class Day04
    {
        public string EncryptedNames;
        public int SectorIdSum = 0;

        public Day04(string input)
        {
            EncryptedNames = input;
            ParseEncryptedNames();
        }

        private void ParseEncryptedNames () {
            var lines = EncryptedNames.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var encryptedName in lines) {
                Room r = new Room(encryptedName);
                if (r.IsRealRoom()) {
                    SectorIdSum += r.SectorId;
                }
            }
        }
    }

    public class Room {

        public string EncryptedData = String.Empty;
        public string EncryptedName = String.Empty;
        public int SectorId;
        public string Checksum = String.Empty;

        public Room (string encryptedData){
            EncryptedData = encryptedData;
            DecryptData();
        }

        private void DecryptData () {
            // aaaaa-bbb-z-y-x-123[abxyz]
            string pattern = @"^(?<encryptedname>[-a-z]+)(?<sectorid>[0-9]+)\[(?<checksum>[a-z]{5})\]$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(EncryptedData);
            if (match.Success)
            {
                EncryptedName = match.Groups["encryptedname"].Value;
                // Remove the last dash
                EncryptedName = EncryptedName.Substring(0, EncryptedName.Length - 1);
                Checksum = match.Groups["checksum"].Value;
                Int32.TryParse(match.Groups["sectorid"].Value, out SectorId);
            }
        }

        public string CalculateChecksum () {
            string checksum = String.Empty;
            SortedDictionary<char, int> letters = new SortedDictionary<char, int>();
            foreach (var c in EncryptedName) {
                if (Char.IsLetter(c)) {
                    if (letters.Keys.Contains(c)) {
                        letters[c]++;
                    } else {
                        letters.Add(c, 1);
                    }
                }
            }
            var top5 = letters.OrderByDescending(pair => pair.Value).Take(5);
            foreach (var letter in top5) {
                checksum += letter.Key;
            }
            return checksum;
        }

        public bool IsRealRoom () {
            return CalculateChecksum() == Checksum;
        }

    }
}
