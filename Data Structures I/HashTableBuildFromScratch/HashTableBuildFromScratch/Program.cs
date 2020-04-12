using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableBuildFromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new HashTable();

            table.Put(6, "A"); // 1
            table.Put(8, "B"); // 3
            table.Put(11, "C"); // 1
            table.Put(6, "A+"); // 1
            //table.Remove(6);
            Console.WriteLine(table.Get(6));
        }
    }
}
