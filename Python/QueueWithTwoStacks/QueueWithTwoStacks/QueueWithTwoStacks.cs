using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithTwoStacks
{
    class QueueWithTwoStacks
    {
        private Stack<int> stack1 = new Stack<int>(5);
        private Stack<int> stack2 = new Stack<int>(5);
        //private int countQueue = 0;

        public void enqueue(int item)
        {
            stack1.Push(item);
        }

        public int dequeue()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
                throw new StackOverflowException();

            if (stack2.Count == 0) reverseStack();

            return stack2.Pop();
        }

        public void reverseStack()
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        public int peek()
        {
            if (isEmpty())
                throw new StackOverflowException();

            if (stack2.Count == 0) reverseStack();

            return stack2.Peek();
        }

        public bool isEmpty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
        }
    }
}
