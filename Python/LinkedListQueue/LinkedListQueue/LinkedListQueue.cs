using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
    public class LinkedListQueue
    {
        private class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int count = 0;

        //Enqueue
        public void Enqueue(int value)
        {
            var node = new Node(value);

            if (isEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
            count++;
        }

        //Dequeue
        public int Dequeue()
        {
            var value = 0;

            if (isEmpty())
                throw new ArgumentNullException();

            if (first == last)
            {
                value = first.value;
                first = last = null;
                return value;
            }

            value = first.value;
            var second = first.next;
            first.next = null;
            first = second;
            

            count--;
            return value;
        }

        //peek
        public int Peek()
        {
            if (isEmpty())
                throw new ArgumentNullException();

            return first.value;
        }

        //size
        public int Size()
        {
            return count;
        }

        //isEmpty
        public bool isEmpty()
        {
            return count == 0;
        }

    }
}
