using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new LinkedListQueue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine("The size of the queue is " + queue.Size());
            Console.WriteLine("The first value in the queue is " + queue.Peek());

            for (int i = 0; i < 5; i++)
                Console.WriteLine(queue.Dequeue());
        }
    }
}
