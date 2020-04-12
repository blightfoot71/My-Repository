using System;
using System.Collections.Generic;

namespace StringExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a time value in 24-hour time format e.g. 19:00: ");
            var input = Console.ReadLine();

            if (IsValidTime(input))
                Console.WriteLine("Valid Time.");
            else
            {
                Console.WriteLine("Invalid Time.");
            }
        }

        public static bool IsValidTime(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return false;

            var times = input.Split(':');

            if (times.Length != 2)
                return false;

            var hours = Convert.ToInt32(times[0]);
            var minutes = Convert.ToInt32(times[1]);

            if ((hours >= 0 && hours <= 23) && (minutes >= 0 && minutes <= 59))
                return true;

            return false;
        }
    }
}
