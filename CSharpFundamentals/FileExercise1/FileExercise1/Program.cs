using System;
using System.IO;

namespace FileExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"d:\Users\Brian\Documents\Programing with Mosh\Beginners Course\textfile.txt";

            var fileContents = File.ReadAllText(path);

            var words = fileContents.Split(' ');

            Console.WriteLine("This number of words in the file is/are: " + words.Length);

            var max = 0;
            var longestWord = "";

            foreach (var word in words)
            {
                if (word.Length > max)
                {
                    longestWord = word;
                    max = word.Length;
                }
            }

            Console.WriteLine("The longest word in the file is '{0}'." , longestWord);
        }
    }
}
