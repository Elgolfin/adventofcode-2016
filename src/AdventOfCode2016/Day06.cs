using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day06
    {
        public string Input = String.Empty;
        public Dictionary<int, Dictionary<char, int>> Columns = new Dictionary<int, Dictionary<char, int>>();
        public string Message = String.Empty;

        public enum OrderBy {Asc, Desc}; 

        public Day06(string input)
        {
            Input = input;
            ParseInput();
        }

        public void ParseInput () {
            var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                ParseLine(line);
            }
        }

        public void GetMessage (OrderBy orderBy = OrderBy.Desc) {
            var msg = new StringBuilder();
            foreach (var col in Columns) {
                if (orderBy == OrderBy.Desc) {
                    msg.Append(col.Value.OrderByDescending(pair => pair.Value).First().Key);
                }
                else {
                    msg.Append(col.Value.OrderByDescending(pair => pair.Value).Last().Key);
                }
            }
            Message = msg.ToString();
        }

        private void ParseLine(string line) 
        {
            var cpt_col = 0;
            foreach (var c in line) {
                // Create the column entry if it does not exist yet
                if (!Columns.ContainsKey(cpt_col)) {
                    Columns.Add(cpt_col, new Dictionary<char, int>());
                }
                // Create the character entry if it does not exist yet
                var col = Columns[cpt_col];
                if (!col.ContainsKey(c)) {
                    col.Add(c, 0);
                }
                // Increment the occurence of the found character in the column
                col[c]++;
                //Parse next column
                cpt_col++;
            }
        }

    }
}
