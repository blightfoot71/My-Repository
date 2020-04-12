using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        private class Node
        {
            public string label;

            public Node(string label)
            {
                this.label = label;
            }

            public override string ToString()
            {
                return label;
            }
        }

        private Dictionary<string, Node> nodes = new Dictionary<string, Node>();
        private Dictionary<Node, List<Node>> adjacencyList = new Dictionary<Node, List<Node>>();

        public void AddNode(string label)
        {
            var node = new Node(label);

            //if (!nodes.ContainsKey(label))
            //    nodes.Add(label, node);
            nodes[label] = node;
            adjacencyList[node] = new List<Node>();
        }

        public void RemoveNode(string label)
        {
            if (!nodes.ContainsKey(label))
                return;

            var node = nodes[label];
            foreach (var n in adjacencyList.Keys)
                adjacencyList[n].Remove(node);

            adjacencyList.Remove(node);
            nodes.Remove(label);
        }

        public void AddEdge(string from, string to)
        {
            var fromNode = nodes[from];
            if (fromNode == null)
            {
                throw new ArgumentException();
            }

            var toNode = nodes[to];
            if (toNode == null)
            {
                throw new ArgumentException();
            }

            adjacencyList[fromNode].Add(toNode);
        }

        public void RemoveEdge(string from, string to)
        {
            var fromNode = nodes[from];
            var toNode = nodes[to];
            if (fromNode == null || toNode == null)
                return;

            adjacencyList[fromNode].Remove(toNode);
        }

        public void Print()
        {
            foreach (var source in adjacencyList.Keys)
            {
                var targets = adjacencyList[source];
                var targetslist = string.Join(", ", targets);
                if (targets.Count > 0)
                    Console.WriteLine(source + " is connected to " + targetslist);
            }
        }

        public void TraverseDepthFirst(string root)
        {
            if (!nodes.ContainsKey(root))
                return;

            TraversDepthFirst(nodes[root], new HashSet<Node>());
        }

        private void TraversDepthFirst(Node root, HashSet<Node> visited)
        {
            Console.WriteLine(root);
            visited.Add(root);

            foreach (var node in adjacencyList[root])
                if (!visited.Contains(node))
                    TraversDepthFirst(node, visited);
        }

        public void TraverseDepthFirstIterative(string root)
        {
            if (!nodes.ContainsKey(root))
                return;

            var stack = new Stack<Node>();
            var visited = new HashSet<Node>();

            stack.Push(nodes[root]);
            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (visited.Contains(current))
                    continue;

                Console.WriteLine(current);
                visited.Add(current);

                foreach (var neighbor in adjacencyList[current])
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }
        }

        public void TraverseBreadthFirstIterative(string root)
        {
            if (!nodes.ContainsKey(root))
                return;

            var queue = new Queue<Node>();
            var visited = new HashSet<Node>();

            queue.Enqueue(nodes[root]);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (visited.Contains(current))
                    continue;

                Console.WriteLine(current);
                visited.Add(current);

                foreach (var neighbor in adjacencyList[current])
                {
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
                }
            }
        }

        public List<string> TopologicalSort()
        {
            var stack = new Stack<Node>();
            var visited = new HashSet<Node>();

            foreach (var node in nodes.Values)
                TopologicalSort(node, visited, stack);

            var dependecies = new List<string>();
            while (stack.Count > 0)
                dependecies.Add(stack.Pop().label);

            return dependecies;
        }

        private void TopologicalSort (Node node, HashSet<Node> visited, Stack<Node> stack)
        {
            if (visited.Contains(node))
                return;
            
            visited.Add(node);

            foreach (var neighbor in adjacencyList[node])
                TopologicalSort(neighbor, visited, stack);
            stack.Push(node);
        }

        public bool HasCycle()
        {
            var all = new HashSet<Node>();
            foreach (var node in nodes.Values)
                all.Add(node);

            var visiting = new HashSet<Node>();
            var visited = new HashSet<Node>();

            while(all.Count > 0)
            {
                var current = all.ToArray()[0];
                if (HasCycle(current, all, visiting, visited))
                    return true;
            }

            return false;
        }

        private bool HasCycle(Node node, HashSet<Node> all, HashSet<Node> visiting, HashSet<Node> visited)
        {
            all.Remove(node);
            visiting.Add(node);

            foreach (var neighbor in adjacencyList[node])
            {
                if (visited.Contains(neighbor))
                    continue;

                if (visiting.Contains(neighbor))
                    return true;

                if (HasCycle(neighbor, all, visiting, visited))
                    return true;
            }

            visiting.Remove(node);
            visited.Add(node);

            return false;
        }
    }
}
