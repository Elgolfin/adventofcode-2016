using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day07
    {

        public int NumberOfIpsSupportingTLS = 0;
        public int NumberOfIpsSupportingSSL = 0;
        string Input;

        public Day07(string input)
        {
            Input = input;
            ParseInput();
        }

        public void ParseInput () {
            var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (String.IsNullOrEmpty(line)) { continue; }
                if (HasABBA(line)) { 
                    NumberOfIpsSupportingTLS++;
                }
                if (HasABA(line)) { 
                    NumberOfIpsSupportingSSL++;
                }
            }
        }

        // ABA means Area-Broadcast Accessor
        // Matches xyx not within brackets and yxy within brackets
        static public bool HasABA (string input) {
            
            string tmpInput = input;

            // Extract the brackets and remove them from the input string
            string pattern = @"\[[a-z]+\]";
            List<string> brackets = new List<string>();
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match m in matches) {
                if (m.Success) {
                    brackets.Add(m.Value);
                }
                tmpInput = tmpInput.Replace(m.Value, ".");
            }

            // Look for the pattern in the trimmed input string (the one with no brackets)
            var mask = $".{tmpInput.Substring(0,2)}";
            for (int i = 2 ; i < tmpInput.Length ; i++) {
                
                mask = $"{mask.Substring(1,2)}{tmpInput[i]}";
                // For each match, find the corresponding match in the brackets except if the match is three same characters
                // We look for pattern like aba not aaa (also ignores '.' character)
                if (mask[0] == mask[2] && mask[0] != mask[1] && mask[0] != '.' && mask[1] != '.') {
                    var lookFor = $"{mask[1]}{mask[0]}{mask[1]}";
                    foreach (var b in brackets) {
                        if (b.Contains(lookFor)) {
                            return true;
                        }
                    }
                }
                
            }

            return false;
        }

        // ABBA means Autonomous Bridge Bypass Annotation
        // Matches xyyx or xxxx but not within brackets
        static public bool HasABBA (string input) {
            string tmpInput = input;
            string pattern = @"\[[a-z]+\]";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match m in matches) {
                if (m.Success && ContainsXYYX(m.Value)) {
                    return false;
                }
                tmpInput = tmpInput.Replace(m.Value, ".");
            }
            return ContainsXYYX(tmpInput);
        }

        private static bool ContainsXYYX(string input) {
            string pattern = @"([a-z])([a-z])\2\1";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match m in matches) {
                if (m.Value[0] != m.Value[1]) {
                    return true;
                }
            }
            return false;
        }

    }
}
