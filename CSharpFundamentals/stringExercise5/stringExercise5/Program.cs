using System;

namespace stringExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an English word: ");

            var word = Console.ReadLine().ToLower();
            // Note the ToLower() here. This is used to count for both A and a.
            
            Console.WriteLine("The number of vowels in your word is: " + CountTheVowels(word));
        }

        public static int CountTheVowels(string word)
        {
            var count = 0;
            for (var i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                    count++;
            }

            return count;
        }
    }
}
