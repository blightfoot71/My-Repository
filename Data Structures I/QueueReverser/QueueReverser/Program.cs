using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            reverse(queue);


            for (int i= 0; i< 3; i++) 
                Console.WriteLine(queue.Dequeue());

        }

        public static void reverse(Queue<int> queue)
        {
            var stack = new Stack<int>();

            while (queue.Count > 0)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());
        }
    }
}
