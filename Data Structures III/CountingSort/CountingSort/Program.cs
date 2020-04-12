using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {  };

            var sorter = new CountingSort();
            sorter.Sort(numbers);

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
