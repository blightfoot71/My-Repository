using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var searcher = new Search();

            Console.WriteLine("The index of the number is: " + searcher.ExponentialSearch(numbers, 10));

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

        }
    }
}
