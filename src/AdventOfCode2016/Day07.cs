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
        string Input;

        public Day07(string input)
        {
            Input = input;
            ParseInput();
        }

        public void ParseInput () {
            var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (HasABBA(line)) { 
                    NumberOfIpsSupportingTLS++;
                }
            }
        }
        
        // ABBA means Autonomous Bridge Bypass Annotation
        // ([a-z])([a-z])\2\1 // Matches xyyx or xxxx but not within brackets
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
        private static bool ContainsXYYX (string input) {
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
