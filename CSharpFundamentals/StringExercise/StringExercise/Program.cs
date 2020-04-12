using System;
using System.Collections.Generic;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            if (AreNumbersConsecutive(input))
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");
        }

        public static bool AreNumbersConsecutive(string input)
        {
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 0; i < numbers.Count - 1; i++)
                if (numbers[i + 1] != numbers[i] + 1)
                {
                    isConsecutive = false;
                    break;
                }

            return isConsecutive;
        }
    }
}
