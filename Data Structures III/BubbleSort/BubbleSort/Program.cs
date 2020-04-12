using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var sorter = new BubbleSort();

            sorter.Sort(numbers);
            
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
