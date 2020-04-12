using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 7, 3, 5, 2, 3, 1, 5, 8 };

            var sorted = new InsertionSort();

            sorted.Sort(numbers);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
