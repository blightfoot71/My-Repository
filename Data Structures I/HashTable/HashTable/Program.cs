using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hash = new Dictionary<int, string>();

            hash.Add(0, "Brian");
            hash.Add(1, "Mosh");
            hash.Add(2, "John");
            hash.Add(3, "Mary");
            hash.Add(4, null);
            hash[3] = "George";
            hash.Remove(4);
            Console.WriteLine(hash.ContainsKey(1));
            Console.WriteLine(hash.ContainsValue("Mary"));

            for (int i = 0; i < hash.Count(); i++)
                Console.WriteLine(hash[i]);

            foreach (var value in hash.Values)
                Console.WriteLine(value);

            foreach (var value in hash)
                Console.WriteLine(value);

        }
    }
}
