using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    public class CountingSort
    {
        public void Sort(int[] array)
        {
            var countingArray = new int[array.Max() + 1];

            for (var i = 0; i < array.Length; i++)
                countingArray[array[i]]++;

            var j = 0;
            for (var k = 0;  k < countingArray.Length; k++) {
                while (countingArray[k] > 0)
                {
                    array[j++] = k;
                    countingArray[k]--;
                }
            }
        }
    }
}
