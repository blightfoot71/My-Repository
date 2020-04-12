using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            graph.AddNode("X");
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("P");

            graph.AddEdge("X", "A");
            graph.AddEdge("X", "B");
            graph.AddEdge("A", "P");
            graph.AddEdge("B", "P");
            graph.AddEdge("P", "X");

            //graph.Print();

            //Console.WriteLine("Removing node...");
            //graph.RemoveNode("A");
            //graph.RemoveEdge("B", "C");

            //graph.Print();

            //graph.TraverseBreadthFirstIterative("X");

            var dep = new List<string>();
            dep = graph.TopologicalSort();

            foreach (var node in dep)
                Console.WriteLine(node);

            Console.WriteLine();
            Console.WriteLine("Graph contains loop: " + graph.HasCycle());
            Console.WriteLine();

        }
    }
}
