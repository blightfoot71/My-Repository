using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQueue
{
    class ArrayQueue
    {
        private int[] queue;
        private int front = 0;
        private int rear = 0;
        private int count;

        public ArrayQueue(int capacity)
        {
            queue = new int[capacity];
        }

        public void Enqueue(int value)
        {
            if (IsFull()) throw new ArgumentOutOfRangeException();
            queue[rear] = value;
            rear = (rear + 1) % queue.Length;
            count++;
        }

        public int Dequeue()
        {
            if (IsEmpty()) throw new ArgumentOutOfRangeException();
            var item = queue[front];
            queue[front] = 0;
            front = (front + 1) % queue.Length;
            count--;
            return item; 
        }

        public int Peek()
        {
            if (IsEmpty()) throw new ArgumentOutOfRangeException();
            return queue[front];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == queue.Length;
        }

        public void Print()
        {
            for (int i = 0; i < queue.Length; i++)
                Console.WriteLine(queue[i]);
        }
    }
}
