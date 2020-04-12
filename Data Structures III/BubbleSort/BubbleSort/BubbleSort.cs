using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSort
    {
        public void Sort(int[] array)
        {
            var end = array.Length - 1;
            bool isSorted;

            for (int j = 0; j < array.Length - 1; j++)
            {
                isSorted = true;
                for (int i = 0; i < end; i++)
                {
                    if (array[i + 1] < array[i])
                    {
                        Swap(array, i + 1, i);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    return;
                end--;
            }
        }

        private void Swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
