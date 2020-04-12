using System;
using System.Collections.Generic;

namespace StringExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                if (numbers.Contains(Convert.ToInt32(number)))
                {
                    Console.WriteLine("Duplicate.");
                    return;
                }
                numbers.Add(Convert.ToInt32(number));
            }
        }
    }
}
