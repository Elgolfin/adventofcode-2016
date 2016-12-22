using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day21
    {
        public string Input;
        public string ScramblingStr = String.Empty;
        public Queue<string> Instructions = new Queue<string>();
        public Stack<string> ReversedInstructions = new Stack<string>();

        public Day21(string input)
        {
            Input = input;
            ParseLines();
        }

        public void Reset() {
            ParseLines();
        }

        public string ScramblePassword (string str) {
            ScramblingStr = str;
            while (Instructions.Count > 0) {
                var line = Instructions.Dequeue();
                SwapPosition(line);
                RotateBasedOnPosition(line);
                RotateLeft(line);
                RotateRight(line);
                SwapLetter(line);
                ReversePosition(line);
                MovePosition(line);
            }
            return ScramblingStr;
        }

        public string UnScramblePassword (string str) {
            ScramblingStr = str;
            while (ReversedInstructions.Count > 0) {
                var line = ReversedInstructions.Pop();
                UnSwapPosition(line);
                UnRotateBasedOnPosition(line);
                UnRotateLeft(line);
                UnRotateRight(line);
                SwapLetter(line);
                ReversePosition(line);
                UnMovePosition(line);
            }
            return ScramblingStr;
        }

        private void ParseLines () {
            var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (!String.IsNullOrEmpty(line)) {
                    Instructions.Enqueue(line);
                    ReversedInstructions.Push(line);
                }
            }
        }

        private void SwapPosition (string line) {
            string pattern = @"^swap position (?<x>[0-9]) with position (?<y>[0-9])$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            var y = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out x);
                Int32.TryParse(match.Groups["y"].Value, out y);
                ScramblingStr = ScramblingStr.SwapPositionXWithPositionY(x, y);
            }
        }

        private void UnSwapPosition (string line) {
            string pattern = @"^swap position (?<x>[0-9]) with position (?<y>[0-9])$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            var y = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out y);
                Int32.TryParse(match.Groups["y"].Value, out x);
                ScramblingStr = ScramblingStr.SwapPositionXWithPositionY(x, y);
            }
        }

        private void RotateBasedOnPosition (string line) {
            string pattern = @"^rotate based on position of letter (?<x>[a-z])$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = '.';
            if (match.Success)
            {
                x = match.Groups["x"].Value[0];
                ScramblingStr = ScramblingStr.RotateBasedOnPosition(x);
            }
        }

        // Rotate the original string to the left once at a time and check if applying the RotateBasedOnPosition Method on it returns the original string (if yes, the rotated string is the our reversed string)
        private void UnRotateBasedOnPosition (string line) {
            string pattern = @"^rotate based on position of letter (?<x>[a-z])$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = '.';
            var tmpStr = ScramblingStr;
            if (match.Success)
            {
                x = match.Groups["x"].Value[0];
                for (var i = 0; i < ScramblingStr.Length ; i++) {
                    tmpStr = tmpStr.RotateLeft(1);
                    if (tmpStr.RotateBasedOnPosition(x) == ScramblingStr) {
                        ScramblingStr = tmpStr;
                        break;
                    }
                }
            }
        }

        private void RotateLeft (string line) {
            string pattern = @"^rotate left (?<x>[0-9]) step";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out x);
                ScramblingStr = ScramblingStr.RotateLeft(x);
            }
        }
        
        private void UnRotateLeft (string line) {
            string pattern = @"^rotate left (?<x>[0-9]) step";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out x);
                ScramblingStr = ScramblingStr.RotateRight(x);
            }
        }

        private void RotateRight (string line) {
            string pattern = @"^rotate right (?<x>[0-9]) step";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out x);
                ScramblingStr = ScramblingStr.RotateRight(x);
            }
        }

        private void UnRotateRight (string line) {
            string pattern = @"^rotate right (?<x>[0-9]) step";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out x);
                ScramblingStr = ScramblingStr.RotateLeft(x);
            }
        }

        private void SwapLetter (string line) {
            string pattern = @"^swap letter (?<x>[a-z]) with letter (?<y>[a-z])$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = '.';
            var y = '.';
            if (match.Success)
            {
                x = match.Groups["x"].Value[0];
                y = match.Groups["y"].Value[0];
                ScramblingStr = ScramblingStr.SwapLetterXWithLetterY(x, y);
            }
        }

        private void ReversePosition (string line) {
            string pattern = @"^reverse positions (?<x>[0-9]) through (?<y>[0-9])$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            var y = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out x);
                Int32.TryParse(match.Groups["y"].Value, out y);
                ScramblingStr = ScramblingStr.ReversePosition(x, y);
            }
        }

        private void MovePosition (string line) {
            string pattern = @"^move position (?<x>[0-9]) to position (?<y>[0-9])$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            var y = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out x);
                Int32.TryParse(match.Groups["y"].Value, out y);
                ScramblingStr = ScramblingStr.MovePosition(x, y);
            }
        }

        private void UnMovePosition (string line) {
            string pattern = @"^move position (?<x>[0-9]) to position (?<y>[0-9])$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(line);
            var x = 0;
            var y = 0;
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out y);
                Int32.TryParse(match.Groups["y"].Value, out x);
                ScramblingStr = ScramblingStr.MovePosition(x, y);
            }
        }
    }

    public static class Day21Extensions
    {
        /// Swap position X with position Y means that the letters at indexes X and Y (counting from 0) should be swapped.
        public static string SwapPositionXWithPositionY(this String str, int x, int y)
        {
            var newStr = new StringBuilder(str);
            var charx = str[x];
            var chary = str[y];
            newStr[x] = chary;
            newStr[y] = charx;
            return newStr.ToString();
        }

        /// Swap letter X with letter Y means that the letters X and Y should be swapped (regardless of where they appear in the string).
        public static string SwapLetterXWithLetterY(this String str, char x, char y)
        {
            return str.SwapPositionXWithPositionY(str.IndexOf(x), str.IndexOf(y));
        }

        /// Reverse positions X through Y means that the span of letters at indexes X through Y (including the letters at X and Y) should be reversed in order.
        public static string ReversePosition(this String str, int x, int y)
        {
            var strToReverse = str.Substring(x, y - x + 1);
            return str.Replace(strToReverse, strToReverse.Reverse());
        }

        /// Rotate left/right X steps means that the whole string should be rotated; for example, one right rotation would turn abcd into dabc.
        public static string RotateLeft (this string str, int x) {
            var c = x % str.Length;
            return str.Substring(c, str.Length - c) + str.Substring(0, c);
        }

        /// Rotate left/right X steps means that the whole string should be rotated; for example, one right rotation would turn abcd into dabc.
        public static string RotateRight (this string str, int x) {
            var c = x % str.Length;
            return str.Substring(str.Length - c, c) + str.Substring(0, str.Length - c);
        }


        /// Move position X to position Y means that the letter which is at index X should be removed from the string, then inserted such that it ends up at index Y.
        public static string MovePosition (this string str, int x, int y) {
            var newStr = new StringBuilder(str);
            var charx = str[x];
            newStr.Remove(x, 1);
            return newStr.ToString().Insert(y, charx.ToString());
        }

        /// Rotate based on position of letter X means that the whole string should be rotated to the right based on the index of letter X (counting from 0) as determined before this instruction does any rotations. Once the index is determined, rotate the string to the right one time, plus a number of times equal to that index, plus one additional time if the index was at least 4.
        public static string RotateBasedOnPosition (this string str, char x) {
            var charx = str.IndexOf(x);
            var newStr = str.RotateRight(1 + charx);
            if (charx >= 4) {
                newStr = newStr.RotateRight(1);
            }
            return newStr;
        }

        public static string Reverse (this string text)
        {
            if (text == null) { return String.Empty; }
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
        }

    } 
    
}
