using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueReverser
{
    public class QueueReverser
    {
        public static void reverse(Queue<int> queue, int k)
        {
            var stack = new Stack<int>(5);
            //var tempqueue = new Queue<int>(5);

            for (int i = 0; i < k; i++)
                stack.Push(queue.Dequeue());

            //for (int i = 0; i < 5 - k; i++)
            //  tempqueue.Enqueue(queue.Dequeue());

            //for (int i = 0; i < k; i++)
            //  queue.Enqueue(stack.Pop());

            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());


            for (int i = 0; i < queue.Count - k; i++)
                queue.Enqueue(queue.Dequeue());

        }
    }
}
