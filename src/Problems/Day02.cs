using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode1016
{
    public class Day02
    {

        public string CurrentPosition = "5";
        public enum Direction {Left, Right, Up, Down};
        public string Code = String.Empty;

        public Dictionary<string, Dictionary<Direction, string>> KeypadMap_9 = new Dictionary<string, Dictionary<Direction, string>>() {
            {"1", new Dictionary<Direction, string>() {{Direction.Down, "4"}, {Direction.Right, "2"}}},
            {"2", new Dictionary<Direction, string>() {{Direction.Down, "5"}, {Direction.Right, "3"}, {Direction.Left, "1"}}},
            {"3", new Dictionary<Direction, string>() {{Direction.Left, "2"}, {Direction.Down, "6"}}},
            {"4", new Dictionary<Direction, string>() {{Direction.Down, "7"}, {Direction.Right, "5"}, {Direction.Up, "1"}}            },
            {"5", new Dictionary<Direction, string>() {{Direction.Down, "8"}, {Direction.Right, "6"}, {Direction.Up, "2"}, {Direction.Left, "4"}}},
            {"6", new Dictionary<Direction, string>() {{Direction.Down, "9"}, {Direction.Left, "5"}, {Direction.Up, "3"}}},
            {"7", new Dictionary<Direction, string>() {{Direction.Up, "4"}, {Direction.Right, "8"}}},
            {"8", new Dictionary<Direction, string>() {{Direction.Left, "7"}, {Direction.Right, "9"}, {Direction.Up, "5"}}},
            {"9", new Dictionary<Direction, string>() {{Direction.Left, "8"}, {Direction.Up, "6"}}}
        };

        public Dictionary<string, Dictionary<Direction, string>> KeypadMap_13 = new Dictionary<string, Dictionary<Direction, string>>() {
            {"1", new Dictionary<Direction, string>() {{Direction.Down, "3"}}},
            {"2", new Dictionary<Direction, string>() {{Direction.Down, "6"}, {Direction.Right, "3"}}},
            {"3", new Dictionary<Direction, string>() {{Direction.Down, "7"}, {Direction.Right, "4"}, {Direction.Up, "1"}, {Direction.Left, "2"}}},
            {"4", new Dictionary<Direction, string>() {{Direction.Down, "8"}, {Direction.Left, "3"}}            },
            {"5", new Dictionary<Direction, string>() {{Direction.Right, "6"}}},
            {"6", new Dictionary<Direction, string>() {{Direction.Down, "A"}, {Direction.Right, "7"}, {Direction.Up, "2"}, {Direction.Left, "5"}}},
            {"7", new Dictionary<Direction, string>() {{Direction.Down, "B"}, {Direction.Right, "8"}, {Direction.Up, "3"}, {Direction.Left, "6"}}},
            {"8", new Dictionary<Direction, string>() {{Direction.Down, "C"}, {Direction.Right, "9"}, {Direction.Up, "4"}, {Direction.Left, "7"}}},
            {"9", new Dictionary<Direction, string>() {{Direction.Left, "8"}}},
            {"A", new Dictionary<Direction, string>() {{Direction.Up, "6"}, {Direction.Right, "B"}}},
            {"B", new Dictionary<Direction, string>() {{Direction.Down, "D"}, {Direction.Right, "C"}, {Direction.Up, "7"}, {Direction.Left, "A"}}},
            {"C", new Dictionary<Direction, string>() {{Direction.Up, "8"}, {Direction.Left, "B"}}},
            {"D", new Dictionary<Direction, string>() {{Direction.Up, "B"}}}
        };

        public string Instructions = String.Empty;

        public Day02()
        {
            
        }

        public void ParseInstructions () {
            ParseInstructions(Move);
        }

        public void ParseInstructions (MoveDelegate processMove) {
            var lines = Instructions.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                ParseInstructionLine(line, processMove);
            }
        }

        public delegate void MoveDelegate(Direction dir);

        private void ParseInstructionLine (string line, MoveDelegate processMove) {
            
            foreach (var c in line) {
                switch (c) {
                    case 'R':
                        processMove(Direction.Right);
                    break;
                    case 'L':
                        processMove(Direction.Left);
                    break;
                    case 'U':
                        processMove(Direction.Up);
                    break;
                    case 'D':
                        processMove(Direction.Down);
                    break;
                    default:
                    break;
                }
            }
            Code += CurrentPosition.ToString();
        }

        public void Move (Direction dir) {
            
            if (KeypadMap_9[CurrentPosition].Keys.Contains(dir)) {
                CurrentPosition = KeypadMap_9[CurrentPosition][dir];
            }

        }

        public void Move_13 (Direction dir) {
            
            if (KeypadMap_13[CurrentPosition].Keys.Contains(dir)) {
                CurrentPosition = KeypadMap_13[CurrentPosition][dir];
            }

        }
    }
}
