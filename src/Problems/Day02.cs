using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode1016
{
    public class Day02
    {

        public int CurrentPosition = 5;
        public enum Direction {Left, Right, Up, Down};
        public string Code = String.Empty;

        public string Instructions = String.Empty;

        private List<int> CannotMoveUp = new List<int>() {1, 2, 3};
        private List<int> CannotMoveDown = new List<int>() {7, 8, 9};
        private List<int> CannotMoveRight = new List<int>() {3, 6, 9};
        private List<int> CannotMoveLeft = new List<int>() {1, 4, 7};
        public Day02()
        {
            
        }

        public void ParseInstructions () {
            var lines = Instructions.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                ParseInstructionLine(line);
            }
        }

        private void ParseInstructionLine (string line) {
            foreach (var c in line) {
                    switch (c) {
                        case 'R':
                            Move(Direction.Right);
                        break;
                        case 'L':
                            Move(Direction.Left);
                        break;
                        case 'U':
                            Move(Direction.Up);
                        break;
                        case 'D':
                            Move(Direction.Down);
                        break;
                        default:
                        break;
                    }
                }
                Code += CurrentPosition.ToString();
        }

        public void Move (Direction dir) {
            if (CanMove(dir)) {
                switch (dir) {
                    case Direction.Left:
                        CurrentPosition -= 1;
                        break;
                    case Direction.Right:
                        CurrentPosition += 1;
                        break;
                    case Direction.Up:
                        CurrentPosition -= 3;
                        break;
                    case Direction.Down:
                        CurrentPosition += 3;
                        break;
                    default:
                        break;
                }
            }
        }

        private bool CanMove (Direction dir) {
            var canMove = true;
            switch (dir) {
                case Direction.Left:
                    if (CannotMoveLeft.Contains(CurrentPosition)) { canMove = false; }
                    break;
                case Direction.Right:
                    if (CannotMoveRight.Contains(CurrentPosition)) { canMove = false; }
                    break;
                case Direction.Up:
                    if (CannotMoveUp.Contains(CurrentPosition)) { canMove = false; }
                    break;
                case Direction.Down:
                    if (CannotMoveDown.Contains(CurrentPosition)) { canMove = false; }
                    break;
                default:
                    break;
            }
            return canMove;
        }
    }
}
