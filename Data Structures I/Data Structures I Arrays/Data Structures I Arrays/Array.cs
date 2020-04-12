using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_I_Arrays
{
    public class Array
    {
        private int[] items;
        private int count;

        public Array(int length)
        {
            items = new int[length];
        }

        public void insert(int item)
        {
            // If the array is full, resize it
            if (items.Length == count)
            {
                // Create a new array (twice the size)
                int[] newItems = new int[count * 2];

                // Copy all the existing items
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                // Set "items" to this new array
                items = newItems;
            }

            // Add the new item at the end
            items[count] = item;
            count++;
        }

        public void removeAt(int index)
        {
            // Validate the index
            if (index <0 || index >= count)
            {
                // throw new Exception;
            }
            //Shift the items to the left to fill the hole
            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }
        public int indexOf(int item)
        {
            // If we find it, return index
            // Otherwise, return -1
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                    return i;
            }
            return -1;
        }

        public int max()
        {
            int maxNumber = 0;
            for (int i = 0; i < count; i++)
                if (items[i] > maxNumber)
                    maxNumber = items[i];
            return maxNumber;
        }

        public Array intersect(Array other)
        {
            var intersection = new Array(count);

            foreach (int item in items)
                if (other.indexOf(item) >= 0)
                    intersection.insert(item);
            
            return intersection;
        }

        public void reverse()
        {
            int[] reversedItems = new int[count];

            for (int i = 0; i < count; i++)
            {
                reversedItems[i] = items[count - i - 1];
            }

            items = reversedItems;
        }

        public void intsertAt(int item, int index)
        {
            // Validate the index
            if (index < 0 || index >= count)
            {
                // throw new Exception;
                Console.WriteLine("Index out of bounds!");
            }
           
            // If the array is full, resize it
            if (items.Length == count)
            {
                // Create a new array (twice the size)
                int[] newItems = new int[count * 2];

                // Copy all the existing items
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }

                // Set "items" to this new array
                items = newItems;
            }

            //Shift the items to the right 
            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
            count++;
            // Put new item at index
            items[index] = item;

        }
        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

    }
}
