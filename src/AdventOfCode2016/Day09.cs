using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day09
    {
        public string Input;
        public string DecompressedInput;

        public Day09(string input)
        {
            Input = input;
            DecompressedInput = Decompress();
        }

        private void ParseLines ()
        {
        var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (!String.IsNullOrEmpty(line)) {
                    
                }
            }
        }

        public string Decompress ()
        {
            var decompressedString = new StringBuilder();
            var numOfCharToBeRepeated = 0;
            var numOfTimesToBeRepeated = 0;
            var numOfCharToBeRepeated_Str = new StringBuilder();
            var numOfTimesToBeRepeated_Str = new StringBuilder();
            var i = 0;
            while (i < Input.Length)
            {
                if (Input[i] == '(') {

                    numOfCharToBeRepeated_Str = new StringBuilder();
                    numOfTimesToBeRepeated_Str = new StringBuilder();

                    i++;
                    while (Input[i] != 'x') {
                        numOfCharToBeRepeated_Str.Append(Input[i]);
                        i++;
                    }

                    i++;
                    while (Input[i] != ')') {
                        numOfTimesToBeRepeated_Str.Append(Input[i]);
                        i++;
                    }
                    Int32.TryParse(numOfCharToBeRepeated_Str.ToString(), out numOfCharToBeRepeated);
                    Int32.TryParse(numOfTimesToBeRepeated_Str.ToString(), out numOfTimesToBeRepeated);
                    
                    i++;
                    // Here var i is positioned on the closing parenthesis of the marker
                    // Repeat the sequence
                    var strToBeRepeated = Input.Substring(i, numOfCharToBeRepeated);
                    for (int j = 0 ; j < numOfTimesToBeRepeated; j++) {
                        decompressedString.Append(strToBeRepeated);
                    }

                    i += numOfCharToBeRepeated - 1;

                } else {
                    decompressedString.Append(Input[i]);
                }
                i++;
            }
            return decompressedString.ToString();
        }

    }
}
