using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trie
{
    public class TrieArray
    {
        private class Node
        {
            public char value;
            public Node[] children = new Node[26];

            public bool isEndOfWord;

            public Node(char value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return "value=" + value;
            }
        }

        private Node root = new Node(' ');

        public void Insert(string word)
        {
            var current = root;
            foreach (var ch in word)
            {
                var index = ch - 'a';
                if (current.children[index] == null)
                    current.children[index] = new Node(ch);
                current = current.children[index];
            }
            current.isEndOfWord = true;
        }
        
    }
}
