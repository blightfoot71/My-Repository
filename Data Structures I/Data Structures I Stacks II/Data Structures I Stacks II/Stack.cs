using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_I_Stacks_II
{
    public class Stack
    {
        private int[] items = new int[1];
        private int count = 0; //Points to the top of the stack and also keeps track of the number of items in the stack

        public void Push(int value)
        {
           if (count == items.Length)
                ResizeArray();

            items[count] = value;
            count++;

        }

        public int Pop()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException();
            count--;
            return items[count];
        }

        public int Peek()
        {
            if (count == 0) throw new ArgumentOutOfRangeException();
            return items[count - 1];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void ResizeArray()
        {
            var biggerArray = new int[2 * items.Length];

            for (int i = 0; i < count; i++)
            {
                biggerArray[i] = items[i];
            }

            items = biggerArray;
        }
    }
}
