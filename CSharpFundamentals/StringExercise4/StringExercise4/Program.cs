using System;

namespace StringExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a few words separated by a space: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine(ConvertToPascalCase(input));
        }

        public static string ConvertToPascalCase(string input)
        {
            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            return variableName;
        }
    }
}
