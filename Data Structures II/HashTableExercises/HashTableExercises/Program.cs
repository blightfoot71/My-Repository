using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 7, 5, 9, 2, 12, 3};

            var start = DateTime.Now;
            var diff = HashTableExercises.CountPairsWithDiff(numbers, 2);
            var end = DateTime.Now;

            Console.WriteLine(diff);
            Console.WriteLine(end - start);
            Console.WriteLine();

            start = DateTime.Now;
            diff = HashTableExercises.CountPairsWithDiffUsingForLoops(numbers, 2);
            end = DateTime.Now;

            Console.WriteLine(diff);
            Console.WriteLine(end - start);

            var numbers2 = new int[] { 2, 7, 11, 15 };
            var solution = HashTableExercises.TwoSum(numbers, 9);

            foreach (var number in solution)
                Console.WriteLine(number);

        }
    }
}
