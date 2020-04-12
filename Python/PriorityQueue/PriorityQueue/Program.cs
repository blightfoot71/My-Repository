using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new PriorityQueue();

            queue.add(5);
            queue.add(3);
            queue.add(6);

            queue.add(1);
            queue.add(4);


            //Console.WriteLine(queue.remove());
            //Console.WriteLine(queue.remove());
            //Console.WriteLine(queue.remove());
            queue.print();

            Console.WriteLine();

            while (!queue.isEmpty())
            {
                Console.WriteLine(queue.remove());
            }
        }
    }
}
