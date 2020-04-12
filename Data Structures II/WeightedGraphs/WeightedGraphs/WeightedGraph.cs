using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedGraphs
{
    public class WeightedGraph
    {
        private class Node
        {
            private string label;
            private List<Edge> edges = new List<Edge>();

            public Node(string label)
            {
                this.label = label;
            }

            public override string ToString()
            {
                return label;
            }

            public void addEdge(Node to, int weight)
            {
                edges.Add(new Edge(this, to, weight));
            }

            public List<Edge> GetEdges()
            {
                return edges;
            }
        }

        private class Edge 
        {
            private Node from;
            private Node to;
            private int weight;

            public Edge(Node from, Node to, int weight)
            {
                this.from = from;
                this.to = to;
                this.weight = weight;
            }

            public override string ToString()
            {
                return from + "->" + to;
            }
        }

        private Dictionary<string, Node> nodes = new Dictionary<string, Node>();

        public void AddNode(string label)
        {
            nodes[label] = new Node(label);
        }

        public void AddEdge(string from, string to, int weight)
        {
            var fromNode = nodes[from];
            if (fromNode == null)
            {
                throw new ArgumentException();
            }

            var toNode = nodes[to];
            if (toNode == null)
                throw new ArgumentException();

            fromNode.addEdge(toNode, weight);
            toNode.addEdge(fromNode, weight);
        }

        public void Print()
        {
            foreach (var node in nodes.Values)
            {
                var edges = node.GetEdges();
                var edgelist = string.Join(", ", edges);
                if (edges.Count > 0)
                    Console.WriteLine(node + " is connected to " + edgelist);
            }
        }

        public int GetShortestDistance(string from, string to)
        {
            var queue = new Heap.PriorityQueueWithHeap();
            
        }
    }
}
