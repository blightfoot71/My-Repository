using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_I_Linked_Lists
{
    public class LinkedList
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
        private int listSize;

        // addFirst
        public void addFirst(int item)
        {
            var node = new Node(item);

            // Check to see if list is empty or not.
            // If empty set first and last to this node
            if (first == null)
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }
            listSize++;
        }

        // addLast
        public void addLast(int item)
        {
            var node = new Node(item);  // We should never create a node without a value, so to this here instead of next line.
            // node.value = item;   Alternate way to do this

            // Check to see if list is empty or not.
            // If empty set first and last to this node
            if (first == null)
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
            listSize++;
        }


        // deleteFirst
        public void removeFirst()
        {
            if (first == null)
                throw new ArgumentOutOfRangeException(); // Not the correct exception but he was writing in Java

            // Handles the case where there is only one item
            if (first == last)
            {
                first = last = null;
                return;
            }

            // Executed if two or more items exist
            var second = first.next;
            first.next = null;
            first = second;
            listSize--;
        }

        // deleteLast
        public void removeLast()
        {
            if (first == null)
                throw new ArgumentOutOfRangeException(); // Not the correct exception but he was writing in Java

            if (first == last)
            {
                first = last = null;
                listSize = 0;
                return;
            }
            
            // My way
            //var current = first;
            //while (current != null)
            //{
            //    if (current.next == last)
            //        break;
            //    current = current.next;
            //}
            //var previous = current;

            var previous = getPrevious(last); // Mosh's suggested way (refactoring)
            last = previous;
            last.next = null;
            listSize--;
        }

        private Node getPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node)
                    return current;
                current = current.next;
            }
            return null;
        }

        // contains
        public bool contains(int item)
        {
            // Alternate way (literally just the next line!)
            // return indexOf(item) != -1;

            var current = first;
            while (current != null)
            {
                if (current.value == item)
                    return true;
                current = current.next;
            }
            return false;
        }

        // indexOf
        public int indexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item)
                    return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public int size()
        {
            return listSize;
        }

        public int[] toArray()
        {
            if (first == null)
                return null;

            int[] array = new int[listSize];
            var current = first;
            int index = 0;
            while (current != null)
            {
                array[index] = current.value;
                current = current.next;
                index++;
            }
            return array;
        }

        public void reverse()
        {
            var previous = first;
            var current = first.next;

            while (current != null) {
                var next = current.next;
                current.next = previous;

                previous = current;
                current = next;
            }
            last = first;
            last.next = null;
            first = previous;
        }

        public bool isEmpty()
        {
            if (first == null)
                return true;
            else
                return false;
        }

        public int getkthFromTheEnd(int k)
        {
            if (k < 1 || k > listSize)
                throw new ArgumentOutOfRangeException();

            if (isEmpty())
                throw new ArgumentOutOfRangeException();

            var behind = first;

            var front = first;
            // Advance the front pointer to k-1 nodes in front of behind pointer
            for (int i = 0; i < k - 1; i++)
                front = front.next;

            // Traverse the list until the front node reaches the end
            while (front != last)
            {
                front = front.next;
                behind = behind.next;
            }
            // The behind pointer should be pointing at the node kth node from the end.  Return the value.
            return behind.value;    
        }

        public string printMiddle()
        {
            var front = first;
            var back = first;
            while (front != last && front.next != last)
            {
                front = front.next.next;
                back = back.next;
            }
            if (front == last)
                return back.value.ToString();
            else
                return back.value.ToString() + ", " + back.next.value.ToString();
        }

        public bool hasLoop()
        {
            var front = first;
            var back = first;
            while (front != null && front.next != null)
            {
                front = front.next.next;
                back = back.next;
                if (front == back)
                    return true;
            }
            return false;
        }

        // Imported so I could test.  I didn't write this.
        public static LinkedList createWithLoop()
        {
            var list = new LinkedList();
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);

            // Get a reference to 30
            var node = list.last;

            list.addLast(40);
            list.addLast(50);

            // Create the loop
            list.last.next = node;

            return list;
        }

        public void print()
        {
            var current = first;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }
}
