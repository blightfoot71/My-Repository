using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 3, 8, 4, 1, 2 };

            MaxHeap.Heapify(numbers);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
