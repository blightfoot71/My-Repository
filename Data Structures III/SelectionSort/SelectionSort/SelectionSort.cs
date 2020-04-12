using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSort
    {
        public void Sort (int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Swap(array, i, FindMinIndex(i, array));
            }
        }

        private void Swap (int[] array, int index1, int index2)
        {
            var temp = array[index1];

            array[index1] = array[index2];
            array[index2] = temp;
        }

        private int FindMinIndex(int i, int[] array)
        {
            var minIndex = i;

            for (var j = i; j < array.Length; j++)
                if (array[j] < array[minIndex])
                    minIndex = j;

            return minIndex;
        }
    }
}
