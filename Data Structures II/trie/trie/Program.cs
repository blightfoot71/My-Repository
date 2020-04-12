using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trie
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new TrieHash();

            trie.Insert("car");
            trie.Insert("card");
            trie.Insert("care");
            trie.Insert("careful");
            trie.Insert("egg");
            //trie.Traverse();
            //trie.Remove("care");

            //Console.WriteLine(trie.Contains("car"));
            //Console.WriteLine(trie.Contains("care"));

            var words = trie.FindWords("car");
            foreach(var word in words)
                Console.Write(word + " ");
            Console.WriteLine();
        }
    }
}
