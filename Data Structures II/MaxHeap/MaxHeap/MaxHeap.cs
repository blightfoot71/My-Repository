﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxHeap
{
    public class MaxHeap
    {
        public static void Heapify(int[] array)
        {
            // Optimized Algorithum by not going to leaf nodes and by starting at the end and counting backwards to reduce recursions.
            var lastParentIndex = array.Length / 2 - 1;
            for (var i = lastParentIndex; i >= 0; i--)
            {
                Heapify(array, i);
            }
        }

        private static void Heapify(int[] array, int index)
        {
            var largerIndex = index;

            var leftIndex = index * 2 + 1;
            if (leftIndex < array.Length && array[leftIndex] > array[largerIndex])
                largerIndex = leftIndex;

            var rightIndex = index * 2 + 2;
            if (rightIndex < array.Length && array[rightIndex] > array[largerIndex])
                largerIndex = rightIndex;

            if (index == largerIndex)
                return;

            Swap(array, index, largerIndex);

            Heapify(array, largerIndex);
        }

        private static void Swap(int[] array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
