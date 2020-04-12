using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort
    {
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
        
        private void Sort(int[] array, int start, int end)
        {
            if (start >= end)
                return;

            var boundary = Partition(array, start, end);

            Sort(array, start, boundary - 1);
            Sort(array, boundary + 1, end);

        }

        private int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int boundary = start - 1;

            for (var i = start; i <= end; i++)
                if (array[i] <= pivot)
                    Swap(++boundary, i, array);

            return boundary;
        }

        private void Swap(int index1, int index2, int[] array)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
