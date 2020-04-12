using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtils
{
    public class StringUtils
    {
        public static int countVowels(string str)
        {
            if (str == null)
                return 0;

            int count = 0;
            string vowels = "aeiou";

            foreach (var ch in str.ToLower())
                if (vowels.IndexOf(ch) != -1)
                    count++;

            return count;
        }

        public static string reverse(string str)
        {
            if (str == null)
                return "";
            
            var reversed = new StringBuilder();
            for (var i = str.Length - 1; i >= 0; i--)
                reversed.Append(str.ToCharArray(i, 1));

            return reversed.ToString();
        }

        public static string reverseWords(string sentence)
        {
            if (sentence == null)
                return ""; 
            
            string[] words = sentence.Split(' ');
            var reversedWords = new StringBuilder();

            for (var i = words.Length - 1; i >= 0; i--)
                reversedWords.Append(words[i] + " ");

            return reversedWords.ToString().Trim();
        }

        public static bool areRotations(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            
            return (str1.Length == str2.Length && (str1 + str1).Contains(str2));
        }

        public static string removeDuplicates(string str)
        {
            if (str == null)
                return "";
            
            var output = new StringBuilder();
            var seen = new HashSet<char>();

            foreach (var ch in str)
            {
                if (!seen.Contains(ch))
                {
                    seen.Add(ch);
                    output.Append(ch);
                }
            }

            return output.ToString();
        }

        public static char mostRepeatedChar(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            if (str.Length == 0)
                throw new ArgumentException();
            
            const int ASCII_SIZE = 256;
            var frequencies = new int[ASCII_SIZE];
            
            foreach (var ch in str)
            {
                frequencies[ch]++;
            }

            var max = 0;
            var result = ' ';
            for (var i = 0; i < frequencies.Length; i++)
            {
                if (frequencies[i] > max)
                {
                    max = frequencies[i];
                    result = (char) i;
                }
            }

            return result;
        }

        public static string capitalize(string sentence)
        {
            if (sentence == null || sentence.Trim().Length == 0)
                return "";
            
            string[] words = sentence.Trim().Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }

            return String.Join(" ", words);
        }

        public static bool areAnagrams(string str1, string str2)
        {
            if (str1 == null | str2 == null || str1.Length != str2.Length)  // Length check is just a quick optimization against long strings
                return false;
            
            var array1 = str1.ToLower().ToCharArray();
            Array.Sort(array1);

            var array2 = str2.ToLower().ToCharArray();
            Array.Sort(array2);

            return array1.SequenceEqual(array2);
        }

        public static bool areAnagrams2(string str1, string str2)
        {
            if (str1 == null | str2 == null || str1.Length != str2.Length)  // Length check is just a quick optimization against long strings
                return false; 
            
            const int ENGLISH_APHABET = 26;
            var frequencies = new int[ENGLISH_APHABET];

            str1 = str1.ToLower();
            foreach (var ch in str1)
                frequencies[ch - 'a']++;

            str2 = str2.ToLower();
            foreach (var ch in str2)
            {
                var index = ch - 'a';
                if (frequencies[index] == 0)
                    return false;

                frequencies[index]--;
            }

            return true;
        }

        public static bool isPalindrome(string word)
        {
            if (word == null)
                return false;

            //return reverse(word).Equals(word);  // my solution alt faster clever solution below

            var left = 0;
            var right = word.Length - 1;

            while(left < right)
                if (word[left++] != word[right--])
                    return false;

            return true;
        }
    }
}
