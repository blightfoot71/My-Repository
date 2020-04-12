using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();

            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(10);

            var tree2 = new Tree();

            tree2.Insert(7);
            tree2.Insert(4);
            tree2.Insert(9);
            tree2.Insert(1);
            tree2.Insert(6);
            tree2.Insert(8);
            tree2.Insert(10);

            //Console.WriteLine(tree.Find(7));
            Console.WriteLine("Pre Order");
            tree.TraversePreOrder();
            Console.WriteLine();
            Console.WriteLine("In Order");
            tree.TraverseInOrder();
            Console.WriteLine();
            Console.WriteLine("Post Order");
            tree.TraversePostOrder();
            Console.WriteLine();
            Console.WriteLine("The height of the tree is... " + tree.Height());
            Console.WriteLine();
            Console.WriteLine("The minimum value in the tree is... " + tree.Min());
            Console.WriteLine();
            Console.WriteLine(tree.Equals(tree2));

            //tree.SwapRoot();
            Console.WriteLine(tree.IsBinarySearchTree());
            Console.WriteLine("Finding Nodes at a Distance...");
            var nodes = tree.GetNodesAtDistance(2);
            foreach (var n in nodes)
                Console.WriteLine(n);
            Console.WriteLine("Traverse tree in level order...");
            tree.TraverseLevelOrder();
            Console.WriteLine();
            Console.WriteLine("The size of the tree is... " + tree.Size());
            Console.WriteLine();
            Console.WriteLine("The number of leaves in the tree is... " + tree.CountLeaves());
            Console.WriteLine();
            Console.WriteLine("The maximum value in the tree is... " + tree.Max());
            Console.WriteLine();
            Console.WriteLine("Does the tree contain a certain value... " + tree.Contains(9));
            Console.WriteLine();
            Console.WriteLine("Are two values siblings... " + tree.AreSiblings(8, 10));
            Console.WriteLine("Finding ancestors of a node...");
            var ancestors = tree.GetAncestors(8);
            foreach (var n in ancestors)
                Console.WriteLine(n);
            Console.WriteLine();
            Console.WriteLine("Checking for balance...");
            Console.WriteLine("The tree is balanced: " + tree.IsBalanced());
            Console.WriteLine();
            Console.WriteLine("Checking for perfection...");
            Console.WriteLine("The tree is perfect: " + tree.IsPerfect());
        }
    }
}
