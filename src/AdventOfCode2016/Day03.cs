using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode1016
{
    public class Day03
    {

        public string[] Triangles;
        public int NumberOfPossibleTriangles = 0;

        public Day03 (string input)
        {
            Regex rgx = new Regex(" +");
            input = rgx.Replace(input, " ");
            Triangles = input.Split('\n').Select(p => p.Trim()).ToArray();
        }

        public Day03 (string input, bool parsingVertically)
        {
            string[] setsOf3;
            Regex rgx = new Regex(" +");
            input = rgx.Replace(input, " ");
            if (parsingVertically) {
                setsOf3 = input.Split('\n').Select(p => p.Trim()).ToArray();
                Triangles = new string[setsOf3.Length];
                var cpt = 0;
                var mod3 = 0;
                foreach (var setOf3 in setsOf3) {
                    var num = setOf3.Split(new string[] { " " }, StringSplitOptions.None).Select(p => p.Trim()).ToArray();
                    Triangles[cpt] += $" {num[0]}";
                    Triangles[cpt+1] += $" {num[1]}";
                    Triangles[cpt+2] += $" {num[2]}";
                    mod3++;
                    if (mod3 % 3 == 0) {
                        cpt = mod3;
                    }
                }
            }
            Triangles = Triangles.Select(p => p.Trim()).ToArray();
        }

        public void ParseTriangles () 
        {
            foreach (var triangle in Triangles) {
                if (IsTriangle(triangle)) {
                    NumberOfPossibleTriangles++;
                }
            }
        }

        private bool IsTriangle (string triangle) 
        {
            int side1;
            int side2;
            int side3;

            var sides = triangle.Split(new string[] { " " }, StringSplitOptions.None).Select(p => p.Trim()).ToArray();
            Int32.TryParse(sides[0], out side1);
            Int32.TryParse(sides[1], out side2);
            Int32.TryParse(sides[2], out side3);
            
            if (side1 + side2 <= side3) { return false; }
            if (side1 + side3 <= side2) { return false; }
            if (side2 + side3 <= side1) { return false; }
            
            return true;
        }
    }
}
