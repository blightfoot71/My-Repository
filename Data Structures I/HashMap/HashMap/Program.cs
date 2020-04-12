using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new HashMap();

            map.Put(10, "Mosh");
            map.Put(20, "Brian");
            map.Put(30, "John");
            map.Put(40, "Fred");

            map.Remove(10);

            Console.WriteLine("The value at hash 20 is: " + map.Get(20));
            Console.WriteLine("The size of the hash table is: " + map.Size());

            // For some reason removing key 30 also removes the value at key 40

        }
    }
}
