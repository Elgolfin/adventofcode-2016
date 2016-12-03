using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode1016
{
    public class Day03
    {

        public List<string> triangles = new List<string>();
        public int NumberOfPossibleTriangles = 0;

        public Day03(string input)
        {
            triangles = input.Split('\n').Select(p => p.Trim()).ToList();
        }

        public void ParseTriangles () 
        {
            foreach (var triangle in triangles) {
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

            var sides = triangle.Split(new string[] { "  " }, StringSplitOptions.None).Select(p => p.Trim()).ToList();
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
