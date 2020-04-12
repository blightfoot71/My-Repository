using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new Heap();

            heap.Insert(10);
            heap.Insert(5);
            heap.Insert(17);
            heap.Insert(4);
            heap.Insert(22);

            //Console.WriteLine(heap.Remove()); 

            Console.WriteLine(heap.KthLargestItem(2));

            Console.WriteLine("Done.");
        }
    }
}
