using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedGraphs
{
    public class Heap
    {
        private int[] items = new int[10];
        private int size;

        public void Insert(int value)
        {
            if (IsFull())
                throw new ArgumentOutOfRangeException();

            items[size++] = value;

            BubbleUp();
        }

        public bool IsFull()
        {
            return size == items.Length;
        }

        private void BubbleUp()
        {
            var index = size - 1;

            while (index > 0 && items[index] > items[Parent(index)])
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }

        private int Parent(int index)
        {
            return (index - 1) / 2;
        }

        private void Swap(int first, int second)
        {
            var temp = items[first];
            items[first] = items[second];
            items[second] = temp;
        }

        public int Remove()
        {
            if (IsEmpty())
                throw new ArgumentNullException();

            var root = items[0];
            items[0] = items[--size];

            BubbleDown();

            return root;
        }

        private void BubbleDown()
        {
            var index = 0;
            while (index <= size && !IsValidParent(index)) 
            {
                var largerChildIndex = LargerChildIndex(index);

                Swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }

        private int LargerChildIndex(int index)
        {
            if (!HasLeftChild(index))
                return index;

            if (!HasRightChild(index))
                return LeftChildIndex(index);

            return (LeftChild(index) > RightChild(index)) ? LeftChildIndex(index) : RightChildIndex(index);
        }

        private bool HasLeftChild(int index)
        {
            return LeftChildIndex(index) <= size;
        }

        private bool HasRightChild(int index)
        {
            return RightChildIndex(index) <= size;
        }

        private bool IsValidParent(int index)
        {
            if (!HasLeftChild(index))
                return true;

            if (!HasRightChild(index))
                return items[index] >= LeftChild(index);

            return items[index] >= LeftChild(index) && items[index] >= RightChild(index);
        }

        private int LeftChild(int index)
        {
            return items[LeftChildIndex(index)];
        }

        private int RightChild(int index)
        {
            return items[RightChildIndex(index)];
        }

        private int LeftChildIndex(int index)
        {
            return 2 * index + 1;
        }

        private int RightChildIndex(int index)
        {
            return 2 * index + 2;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int KthLargestItem(int k)
        {
            if (k < 1 || k > size)
                throw new ArgumentOutOfRangeException();

            // Remove the k - 1 values from the max heap, and the kth largest value will be at the root. ie index 0
            for (var i = 0; i < k - 1; i++)
            {
                Remove();
            }

            return items[0];
        }
    }
}
