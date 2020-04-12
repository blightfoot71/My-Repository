using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trie
{
    class TrieHash
    {
        private class Node
        {
            public char value;
            public Dictionary<char, Node> children = new Dictionary<char, Node>();

            public bool isEndOfWord;

            public Node(char value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return "value=" + value;
            }

            
            public bool hasChild(char ch)
            {
                return children.ContainsKey(ch);
            }

            public void addChild(char ch)
            {
                children[ch] = new Node(ch);
            }

            public Node getChild(char ch)
            {
                if (children.ContainsKey(ch))
                    return children[ch];
                else
                    return null;
            }

            public Node[] getChildren()
            {
                return children.Values.ToArray();
            }

            public bool hasChildren()
            {
                return children.Count != 0;
            }

            public void removeChild(char ch)
            {
                children.Remove(ch);
            }
        }

        private Node root = new Node(' ');

        public void Insert(string word)
        {
            var current = root;
            foreach (var ch in word)
            {
                if (!current.hasChild(ch))
                    current.addChild(ch);
                current = current.getChild(ch);
            }
            current.isEndOfWord = true;
        }

        public bool Contains(string word)
        {
            if (word == null)
                return false;

            var current = root;
            foreach (var ch in word)
            {
                if (!current.hasChild(ch))
                    return false;
                current = current.getChild(ch);
            }

            return current.isEndOfWord;
        }

        public void Traverse()
        {
            Traverse(root);
        }

        private void Traverse(Node root)
        {
            //Pre-order: visit the root first
            Console.WriteLine(root.value);

            foreach (var child in root.getChildren())
                Traverse(child);
        }

        public void Remove(string word)
        {
            if (word == null)
                return;

            Remove(root, word, 0);
        }

        private void Remove(Node root, string word, int index)
        {
            if (index == word.Length)
            {
                root.isEndOfWord = false;
                return;
            }

            var ch = word.ElementAt(index);
            var child = root.getChild(ch);
            if (child == null)
                return;

            Remove(child, word, index + 1);

            if (!child.hasChildren() && !child.isEndOfWord)
                root.removeChild(ch);
        }

        public List<string> FindWords(string prefix)
        {
            var words = new List<string>();
            var lastNode = findLastNodeOf(prefix);
            FindWords(lastNode, prefix, words);

            return words;
        }

        private void FindWords(Node root, string prefix, List<string> words)
        {
            if (root == null)
                return;

            if (root.isEndOfWord)
                words.Add(prefix);

            foreach (var child in root.getChildren())
                FindWords(child, prefix + child.value, words);
        }

        private Node findLastNodeOf(string prefix)
        {
            if (prefix == null)
                return null;

            var current = root;
            foreach (var ch in prefix.ToCharArray())
            {
                var child = current.getChild(ch);
                if (child == null)
                    return null;

                current = child;
            }

            return current;
        }
    }
}
