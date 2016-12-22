using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace AdventOfCode1016
{
    public class Day22
    {
        public string Input;
        public Dictionary<string, Node> Grid = new Dictionary<string, Node>();
        public List<string> ViablePairs = new List<string>();

        public Day22(string input)
        {
            Input = input;
            ParseLines();
            GetViablePairs();
        }

        public void Reset() {
            ParseLines();
            ViablePairs = new List<string>();
            GetViablePairs();
        }

        private void GetViablePairs () {
            foreach (var node1 in Grid.Values) {
                foreach (var node2 in Grid.Values) {
                    if (IsViablePair(node1, node2)) {
                        ViablePairs.Add($"{node1.Id},{node2.Id}");
                    }
                }
            }
        }

        /// Node A is not empty (its Used is not zero).
        /// Nodes A and B are not the same node.
        /// The data on node A (its Used) would fit on node B (its Avail).

        private bool IsViablePair (Node nodeA, Node nodeB) {
            if (nodeA.Used <= 0) { return false; }
            if (nodeA.Id == nodeB.Id) { return false; }
            if (nodeA.Used > nodeB.Available) { return false; }
            return true;
        }

        private void ParseLines () {
            Grid = new Dictionary<string, Node>();
            var lines = Input.Split('\n').Select(p => p.Trim()).ToList();
            foreach (var line in lines) {
                if (!String.IsNullOrEmpty(line)) {
                    var node = new Node(line);
                    if (!String.IsNullOrEmpty(node.Id)) {
                        Grid.Add(node.Id, node);
                    }
                }
            }
            // Create nodes links will take place here
        }
    }

    public class Node {
        public string Id;
        public int Size;
        public int Used;
        public int Available;
        public int X;
        public int Y;
        public string Name;
        List<Node> AdjacentNodes = new List<Node>();

        public Node (string nodeLine) {
            ParseNodeLine(nodeLine);
        }

        private void ParseNodeLine (string nodeLine) {
            string pattern = @"^/dev/grid/node-x(?<x>[0-9]+)-y(?<y>[0-9]+)\s+(?<size>[0-9]+)T\s+(?<used>[0-9]+)T\s+(?<available>[0-9]+)T\s+[0-9]+%$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(nodeLine);
            if (match.Success)
            {
                Int32.TryParse(match.Groups["x"].Value, out X);
                Int32.TryParse(match.Groups["y"].Value, out Y);
                Int32.TryParse(match.Groups["size"].Value, out Size);
                Int32.TryParse(match.Groups["used"].Value, out Used);
                Int32.TryParse(match.Groups["available"].Value, out Available);
                Name = $"node-x{X}-y{Y}";
                Id = $"{X},{Y}";
            }
        }

        public override string ToString() {
            return $"/dev/grid/{Name}  {Size}T  {Used}T  {Available}T";
        }

    }
    
}
