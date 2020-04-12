using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class Search
    {
        public int LinearSearch(int[] array, int target)
        {
            for (var i = 0; i < array.Length; i++)
                if (array[i] == target)
                    return i;
            
            return -1;
        }

        public int BinarySearchRec(int[] array, int target)
        {
            return BinarySearchRec(array, target, 0, array.Length - 1);
        }
        
        private int BinarySearchRec(int[] array, int target, int left, int right)
        {
            if (right < left)
                return -1;
            
            var middle = (left + right) / 2;

            if (array[middle] == target)
                return middle;

            if (target < array[middle])
                return BinarySearchRec(array, target, left, middle - 1);

            return BinarySearchRec(array, target, middle + 1, right);
        }

        public int BinarySearchInt(int[] array, int target)
        {
            var left = 0;
            var right = array.Length - 1;

            while (right >= left)
            {
                var middle = (left + right) / 2;
                if (array[middle] == target)
                    return middle;

                if (target < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }

        public int TernarySearchRec(int[] array, int target)
        {
            return TernarySearchRec(array, target, 0, array.Length - 1);
        }

        private int TernarySearchRec(int[] array, int target, int left, int right)
        {
            if (right < left)
                return -1;

            var partionSize = (right - left) / 3;
            var mid1 = left + partionSize;
            var mid2 = right - partionSize;

            if (array[mid1] == target)
                return mid1;

            if (array[mid2] == target)
                return mid2;

            if (target > array[mid2])
                return TernarySearchRec(array, target, mid2 + 1, right);

            if (target < array[mid1])
                return TernarySearchRec(array, target, left, mid1 - 1);

            return TernarySearchRec(array, target, mid1 + 1, mid2 - 1);
        }

        public int JumpSearch(int[] array, int target)
        {
            var start = 0;
            var blockSize = Convert.ToInt32(Math.Sqrt(array.Length));
            var next = blockSize;

            while (start < array.Length && target > array[next - 1])
            {
                start = next;
                next += blockSize;

                if (next > array.Length)
                    next = array.Length;
            }
            
            for (var i = start; i < next; i++)
                if (target == array[i])
                    return i;

            return -1;
        }

        public int ExponentialSearch(int[] array, int target)
        {
            var bound = 1;
            var left = 0;

            while(bound < array.Length)
            {
                if (target <= array[bound])
                    return BinarySearchRec(array, target, left, bound);
                left = bound;
                bound *= 2;
            }

            return BinarySearchRec(array, target, left, array.Length - 1);

            // Mosh's Solution (I was very close)
            //int bound = 1;
            //while (bound < array.Length && array[bound] < target)
            //    bound *= 2;

            //int left = bound / 2;
            //right = Math.Min(bound, array.Length - 1);

            //return BinarySearchRec(array, target, left, right);

        }
    }
}
