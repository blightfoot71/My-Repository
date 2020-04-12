﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedGraphs
{
    public class PriorityQueueWithHeap
    {
        private Heap heap = new Heap();

        public void Enqueue(int item)
        {
            heap.Insert(item);
        }

        public int Dequeue()
        {
            return heap.Remove();
        }

        public bool IsEmpty()
        {
            return heap.IsEmpty();
        }
    }
    
}
