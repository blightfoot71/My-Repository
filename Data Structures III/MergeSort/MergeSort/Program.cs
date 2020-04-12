using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 5, 2, 3, 1, 5, 8 };

            var sorter = new MergeSort();
            sorter.Sort(numbers);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
