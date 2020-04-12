using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 7, 3, 1, 2, 5, 6, 8, 3 };

            var sorted = new SelectionSort();

            sorted.Sort(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
