using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);


            QueueReverser.reverse(queue, 5);

            for (int i = 0; i < 5; i++)
                Console.WriteLine(queue.Dequeue());

            
        }
    }
}
