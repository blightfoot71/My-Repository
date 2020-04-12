using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "orange";
            Console.WriteLine(str.GetHashCode());
            //var map = new Dictionary<string, string>();

            //map.Add("123456-A", "Mosh");
            //Console.WriteLine(hash("123456-A"));
        }

        static int hash(string key)
        {
            int hash = 0;
            foreach (var ch in key)
                hash += ch;

            return hash % 100;
        }
    }
}
