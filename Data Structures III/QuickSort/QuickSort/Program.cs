using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 5, 7, 2, 3, 1, 2 };

            var sorter = new QuickSort();
            sorter.Sort(numbers);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
