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
        public int Width;
        public int Height;

        public Day22(string input)
        {
            Input = input;
            ParseLines();
            GetViablePairs();
        }

        public int MoveData (string from, string to = "0,0") {
            var sum = 0;
            var goalPath = FindShortestPath(from, to);
            var nodesFromGoalPath = goalPath.Split('|');
            for (var i = 1 ; i < nodesFromGoalPath.Length; i++) {
                var emptyPath = FindShortestPath(GetEmptyNode().Id, nodesFromGoalPath[i]);
                var nodesFromEmptyPath = emptyPath.Split('|');
                for (var j = 1 ; j < nodesFromEmptyPath.Length; j++) {
                    var emptyFrom = Grid[nodesFromEmptyPath[j]];
                    var emptyTo = Grid[nodesFromEmptyPath[j-1]];
                    //Console.WriteLine($"Move data from {emptyFrom.Name} to {emptyTo.Name}");
                    SwapData(nodesFromEmptyPath[j-1], nodesFromEmptyPath[j]);
                    sum++;
                }
                var goalFrom = Grid[nodesFromGoalPath[i-1]];
                var goalTo = GetEmptyNode();
                //Console.WriteLine($"Move the goal data from {goalFrom.Name} to {goalTo.Name}");
                SwapData(goalFrom, goalTo);
                sum++;
            }
            return sum;
        }

        public void SwapData (string from, string to) {
            SwapData(Grid[from], Grid[to]);
        }

        /// The assumption here (because there is no error check) is that the target Node is empty and can receive the amount of moved data
        public void SwapData (Node from, Node to) {
            var tmpData = to.Used;
            to.Used = from.Used;
            from.Used = tmpData;

            if (from.IsGoal) {
                to.IsGoal = true;
                from.IsGoal = false;
            }

            from.Available = from.Size - from.Used;
            to.Available = to.Size - to.Used;
        }

        public void Reset() {
            ParseLines();
            ViablePairs = new List<string>();
            GetViablePairs();
        }

        public Node GetEmptyNode () {
            return Grid.Values.Where(n => n.Used == 0).First();
        }

        public string FindShortestPath (string from, string to)
        {
            return FindShortestPath(Grid[from], Grid[to]);
        }

        public string FindShortestPath (Node from, Node to)
        {
            var _Paths = new Queue<string>();
            _Paths.Enqueue(from.Id);
            from.DistanceFromStart = 0;
            //from.Predecessor = null; // useless
            var visitedNodes = new List<string>();
            var currentNode = from;
            while (_Paths.Count > 0) {
                var currentQueueElement = _Paths.Dequeue();
                var currentNodeId = currentQueueElement.Split('|').Last();
                currentNode = Grid[currentNodeId];
                if (currentNode.Id == to.Id) {
                    return currentQueueElement;
                }
                if (visitedNodes.Contains(currentNode.Id)) {
                    continue;
                }
                foreach (var adjacentNode in currentNode.AdjacentNodes) {
                    if (!visitedNodes.Contains(adjacentNode.Id) && !adjacentNode.VeryFullNode && !adjacentNode.IsGoal) { 
                        adjacentNode.DistanceFromStart = currentNode.DistanceFromStart + 1;
                        //adjacentNode.Predecessor = currentNode; // useless
                        _Paths.Enqueue($"{currentQueueElement}|{adjacentNode.Id}");
                    }
                }
                visitedNodes.Add(currentNode.Id);
                
            }
            return String.Empty;
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
                        Width = Math.Max(Width, node.X + 1);
                        Height = Math.Max(Height, node.Y + 1);
                    }
                }
            }
            
            // Link the nodes together
            foreach (var node in Grid.Values) {
                if (node.X - 1 >= 0) {
                    var nodeToAdd = Grid[$"{node.X - 1},{node.Y}"];
                    node.AdjacentNodes.Add(nodeToAdd);
                }
                if (node.X + 1 < Width) {
                    var nodeToAdd = Grid[$"{node.X + 1},{node.Y}"];
                    node.AdjacentNodes.Add(nodeToAdd);
                }
                if (node.Y - 1 >= 0) {
                    var nodeToAdd = Grid[$"{node.X},{node.Y - 1}"];
                    node.AdjacentNodes.Add(nodeToAdd);
                }
                if (node.Y + 1 < Height) {
                    var nodeToAdd = Grid[$"{node.X},{node.Y + 1}"];
                    node.AdjacentNodes.Add(nodeToAdd);
                }
            }

            // Set the Goal Node
            Grid[$"{Width - 1},0"].IsGoal = true;

            // Move the empty to node to the next node where the Goal should Move
            // Two routes = 1) the one with the Goal
            //              2) the one with the empty

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
        public List<Node> AdjacentNodes = new List<Node>();
        public int DistanceFromStart = 0;
        public Node Predecessor;
        public bool IsGoal;
        public bool VeryFullNode {
            get {
                return Size > 500;
            }
            set {}
        }
        public bool IsEmpty {
            get {
                return Size == 0;
            }
            set {}
        }

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
                Name = $"node-y{Y}-x{X}";
                Id = $"{X},{Y}";
            }
        }

        public override string ToString() {
            return $"/dev/grid/node-x{X}-y{Y}  {Size}T  {Used}T  {Available}T";
        }

    }
    
}
