using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithTwoStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new QueueWithTwoStacks();

            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);

            //queue.dequeue();
            //queue.dequeue();


            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            //Console.WriteLine(queue.dequeue());
        }
    }
}
