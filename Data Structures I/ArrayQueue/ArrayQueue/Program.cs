using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new ArrayQueue(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(60);
            queue.Dequeue();
            queue.Enqueue(70);


            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            Console.WriteLine();
            Console.WriteLine(queue.Peek());
            Console.WriteLine();

            queue.Print();
        }
    }
}
