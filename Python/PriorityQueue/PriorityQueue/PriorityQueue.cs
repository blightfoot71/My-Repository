using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    class PriorityQueue
    {
        private int[] items;
        private int count = 0;
        
        public PriorityQueue()
        {
            items = new int[5];
        }

        public void add(int item)
        {
            if (isFull())
                throw new IndexOutOfRangeException();

            var i = shiftItemsToInsert(item);
            items[i] = item;
            count++;
        }

        public int remove() //For some reason we are removing the largest values first
        {
            if (isEmpty())
                throw new IndexOutOfRangeException();

            return items[--count];
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public bool isFull()
        {
            return count == items.Length;
        }

        public int shiftItemsToInsert(int item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i] > item)
                    items[i + 1] = items[i];
                else
                    break;
            }
            return i + 1;
        }

        public void print()
        {
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine(items[i]);
        }
    }
}
