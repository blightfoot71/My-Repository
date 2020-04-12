using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtils
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = StringUtils.countVowels("Hello World");
            Console.WriteLine(count);

            Console.WriteLine(StringUtils.reverse("blue"));

            Console.WriteLine("'" + StringUtils.reverseWords("Trees are beautiful") + "'");

            Console.WriteLine(StringUtils.areRotations("ABCD", ""));

            Console.WriteLine("'" + StringUtils.removeDuplicates("Trees are beautiful") + "'");
            
            Console.WriteLine("'" + StringUtils.mostRepeatedChar(" ") + "'");

            Console.WriteLine("'" + StringUtils.capitalize("   TODAY IS A GREAT DAY   ") + "'");

            Console.WriteLine("Are anagrams: " + StringUtils.areAnagrams("ABCd", "DBCA"));
            
            Console.WriteLine("Are anagrams: " + StringUtils.areAnagrams2("ABCd", "DBCA"));
            
            Console.WriteLine("Is palindrome: " + StringUtils.isPalindrome("abcba"));

        }
    }
}
