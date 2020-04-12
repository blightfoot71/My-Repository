using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 5, 3, 2, 1, 7, 3 };

            var sorter = new BucketSort();
            sorter.Sort(numbers, 3);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
