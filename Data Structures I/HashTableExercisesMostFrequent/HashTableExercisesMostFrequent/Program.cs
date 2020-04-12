using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExercisesMostFrequent
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[]{ 1, 2, 2, 2, 2, 3, 3, 3, 3, 4};

            Console.WriteLine("The most repeated number is: " + HashTableExercises.MostFrequent(numbers));
        }

        
    }
}
