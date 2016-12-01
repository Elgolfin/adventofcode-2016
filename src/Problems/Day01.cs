using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode1016
{
    public class Day01
    {
        
        public int x = 0;
        public int y = 0;
        public enum Direction {North, East, South, West}; 
        public Direction HeadTo = Direction.North;

        public List<string> Path = new List<string>();
        
        public Day01(string path)
        {
            Path = ParsePath(path);
        }

        private List<string> ParsePath (string path) {
            var route = path.Split(',').Select(p => p.Trim()).ToList();
            return route;
        }

        public void MoveAlongThePath () {
            foreach (var code in Path) {
                MoveTo(code);
            }
        }

        public int GetBlocksAwayFromStart () {
            return Math.Abs(x) + Math.Abs(y);
        }

        public void MoveTo (string code) {
            
            var dir = String.Empty;
            var dist = 0;

            string pattern = @"(?<dir>[RL])(?<dist>[0-9]+)$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(code);
            if (match.Success)
            {
                dir = match.Groups["dir"].Value;
                Int32.TryParse(match.Groups["dist"].Value, out dist);
            }

            switch (HeadTo) {
                case Direction.North:
                    GoFromNorthTo(dir, dist);
                    break;
                case Direction.South:
                    GoFromSouthTo(dir, dist);
                    break;
                case Direction.East:
                    GoFromEastTo(dir, dist);
                    break;
                case Direction.West:
                    GoFromWestTo(dir, dist);
                    break;
                default:
                    break;
            }
        }

        public void GoFromNorthTo (string dir, int dist) {
            if (dir == "R") {
                x += dist;
                HeadTo = Direction.East;
            }
            if (dir == "L") {
                x -= dist;
                HeadTo = Direction.West;
            }
        }

        public void GoFromSouthTo (string dir, int dist) {
            if (dir == "R") {
                x -= dist;
                HeadTo = Direction.West;
            }
            if (dir == "L") {
                x += dist;
                HeadTo = Direction.East;
            }
        }

        public void GoFromEastTo (string dir, int dist) {
            if (dir == "R") {
                y -= dist;
                HeadTo = Direction.South;
            }
            if (dir == "L") {
                y += dist;
                HeadTo = Direction.North;
            }
        }

        public void GoFromWestTo (string dir, int dist) {
            if (dir == "R") {
                y += dist;
                HeadTo = Direction.North;
            }
            if (dir == "L") {
                y -= dist;
                HeadTo = Direction.South;
            }
        }
    }
}
