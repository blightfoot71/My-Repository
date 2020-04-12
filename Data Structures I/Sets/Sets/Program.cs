using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<int>();
            var numbers = new int[] { 1, 2, 3, 3, 2, 1, 4 };
            foreach (var number in numbers)
                set.Add(number);

            foreach (int value in set)
                Console.WriteLine(value);
        }
    }
}
