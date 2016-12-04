using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day04
    {
        public string EncryptedNames;
        public int SectorIdSum = 0;
        public List<Room> Rooms = new List<Room>();

        public Day04(string input)
        {
            EncryptedNames = input;
            ParseEncryptedNames();
        }

        private void ParseEncryptedNames () {
            var lines = EncryptedNames.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var encryptedName in lines) {
                Room r = new Room(encryptedName);
                Rooms.Add(r);
                if (r.IsRealRoom()) {
                    SectorIdSum += r.SectorId;
                }
            }
        }
    }

    public class Room {

        public string EncryptedData = String.Empty;
        public string EncryptedName = String.Empty;
        public string Name = String.Empty;
        public int SectorId;
        public string Checksum = String.Empty;

        public Room (string encryptedData){
            EncryptedData = encryptedData;
            DecryptData();
            DecryptName();
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

        // How to decrypt:
        // 1. ascii letter + sector id % 26
        // 2. if the result > 26 (minus 26 and you got the ascii letter)
        // 3. dash '-' transforms into space ' '
        private void DecryptName () {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(EncryptedName);
            foreach (var letter in asciiBytes) {
                if (letter == 45) { // 45 in ascii is space ' '
                    Name += " ";
                } else {
                    var newLetter = letter + (SectorId % 26);
                    if (newLetter > 122) { // 122 in ascii is 'z'
                        newLetter = newLetter - 26;
                    }
                    Name += (char) newLetter;
                }
            }
        }

    }
}
