using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class Tree
    {
        private class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return "Node=" + value;
            }
        }

        private Node root;

        public void Insert(int value)
        {
            var node = new Node(value);

            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;
            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }

                if (value > current.value)
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }

        public bool Find (int value)
        {
            var current = root;

            while (current != null)
            {
                if (value < current.value)
                    current = current.leftChild;
                else if (value > current.value)
                    current = current.rightChild;
                else
                    return true;
            }

            return false;
        }

        public void TraversePreOrder()
        {
            //We need this overload because root is private and can't be called from the main program.
            //Additionally the compiler didn't like the TraversePreOrder(Node root) method being public
            TraversePreOrder(root);
        }

        private void TraversePreOrder(Node root)
        {
            //root (print)
            //left
            //right
            if (root == null)
                return;

            Console.WriteLine(root.value);
            TraversePreOrder(root.leftChild);
            TraversePreOrder(root.rightChild);
        }

        public void TraverseInOrder()
        {
            //We need this overload because root is private and can't be called from the main program.
            //Additionally the compiler didn't like the TraversePreOrder(Node root) method being public
            TraverseInOrder(root);
        }

        private void TraverseInOrder(Node root)
        {
            //left
            //root (print)
            //right
            if (root == null)
                return;

            TraverseInOrder(root.leftChild);
            Console.WriteLine(root.value);
            TraverseInOrder(root.rightChild);
        }

        public void TraversePostOrder()
        {
            //We need this overload because root is private and can't be called from the main program.
            //Additionally the compiler didn't like the TraversePreOrder(Node root) method being public
            TraversePostOrder(root);
        }

        private void TraversePostOrder(Node root)
        {
            //left
            //right
            //root (print)
            if (root == null)
                return;

            TraversePostOrder(root.leftChild);
            TraversePostOrder(root.rightChild);
            Console.WriteLine(root.value);
        }

        public int Height()
        {
            return Height(root);
        }

        private int Height(Node root)
        {
            if (root == null)
                return -1;

            if (IsLeaf(root))
                return 0;

            return 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
        }

        private bool IsLeaf(Node node)
        {
            return node.leftChild == null && node.rightChild == null;
        }

        public int Min()
        {
            return Min(root);
        }

        private int Min(Node root)
        {
            if (root == null)
                return int.MaxValue;

            if (IsLeaf(root))
                return root.value;

            var left = Min(root.leftChild);
            var right = Min(root.rightChild);

            return Math.Min(Math.Min(left, right), root.value);

            // In a binary search tree we just have to find the left most node
            // var current = root;
            // var last = current;
            // while (current != null) {
            //  last = current;
            //  current = current.leftChild;
            // }
            // return last.value;
        }

        public bool Equals(Tree other)
        {
            if (other == null)
                return false;

            return Equals(root, other.root);
        }

        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null)
                return true;

            if (first != null && second != null)
                return first.value == second.value 
                        && Equals(first.leftChild, second.leftChild)
                        && Equals(first.rightChild, second.rightChild);

            return false;
        }

        public void SwapRoot()
        {
            var temp = root.leftChild;
            root.leftChild = root.rightChild;
            root.rightChild = temp;
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root == null)
                return true;

            if (root.value < min || root.value > max)
                return false;

            return  
                IsBinarySearchTree(root.leftChild, min, root.value - 1)
                && IsBinarySearchTree(root.rightChild, root.value + 1, max);
        }

        public List<int> GetNodesAtDistance(int distance)
        {
            var list = new List<int>();
            GetNodesAtDistance(root, distance, list);
            return list;
        }

        private void GetNodesAtDistance(Node root, int distance, List<int> list)
        {
            if (root == null)
                return;

            if (distance == 0)
            {
                list.Add(root.value);
                return;
            }

            GetNodesAtDistance(root.leftChild, distance - 1, list);
            GetNodesAtDistance(root.rightChild, distance - 1, list);
        }

        public void TraverseLevelOrder()
        {
            for (var i = 0; i <= Height(); i++)
            {
                // var list = GetNodesAtDistance(i); Don't need because we only use it once.  Just call it in the foreach loop.
                foreach (var value in GetNodesAtDistance(i))
                    Console.WriteLine(value);
            }
        }

        public int Size()
        {
            return Size(root);
        }

        private int Size(Node root)
        {
            if (root == null)
                return 0;

            if (IsLeaf(root))
                return 1;

            return 1 + Size(root.leftChild) + Size(root.rightChild);
        }

        public int CountLeaves()
        {
            return CountLeaves(root);
        }

        private int CountLeaves(Node root)
        {
            if (root == null)
                return 0;

            if (IsLeaf(root))
                return 1;

            return CountLeaves(root.leftChild) + CountLeaves(root.rightChild);
        }

        public int Max()
        {
            return Max(root);
        }

        private int Max(Node root)
        {
            if (root == null)
                return int.MinValue;

            if (IsLeaf(root))
                return root.value;

            var left = Max(root.leftChild);
            var right = Max(root.rightChild);

            return Math.Max(Math.Max(left, right), root.value);
        }

        public bool Contains(int value)
        {
            return Contains(root, value);
        }

        private bool Contains(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.value == value)
                return true;

            return Contains(root.leftChild, value) || Contains(root.rightChild, value);
        }

        public bool AreSiblings(int lValue, int rValue)
        {
            return AreSiblings(root, lValue, rValue);
        }

        private bool AreSiblings(Node root, int lValue, int rValue)
        {
            if (root == null)
                return false;

            var areSiblings = false;
            if (root.leftChild != null && root.rightChild != null)
            {
                areSiblings = (root.leftChild.value == lValue && root.rightChild.value == rValue) ||
                                (root.rightChild.value == lValue && root.leftChild.value == rValue);
            }
            return areSiblings || AreSiblings(root.leftChild, lValue, rValue) || AreSiblings(root.rightChild, lValue, rValue);
        }

        public List<int> GetAncestors(int value)
        {
            var list = new List<int>();
            GetAncestors(root, value, list);
            return list;
        }

        private bool GetAncestors(Node root, int value, List<int> list)
        {
            if (root == null)
                return false;

            if (root.value == value)
                return true;

            if (GetAncestors(root.leftChild, value, list) || GetAncestors(root.rightChild, value, list)) {
                list.Add(root.value);
                return true;
            }

            return false;
        }

        public bool IsBalanced()
        {
            return IsBalanced(root);
        }

        private bool IsBalanced(Node root)
        {
            if (root == null)
                return true;

            var balanceFactor = Height(root.leftChild) - Height(root.rightChild);

            return Math.Abs(balanceFactor) <= 1 && IsBalanced(root.leftChild) && IsBalanced(root.rightChild);
        }

        public bool IsPerfect()
        {
            return IsPerfect(root);
            // Or...
            // return size() == (Math.Pow(2, height() + 1 - 1);
        }

        private bool IsPerfect(Node root)
        {
            if (root == null)
                return true;

            var isHeightEqual = Height(root.leftChild) == Height(root.rightChild);

            return isHeightEqual && IsPerfect(root.leftChild) && IsPerfect(root.rightChild);
        }
    }
}
