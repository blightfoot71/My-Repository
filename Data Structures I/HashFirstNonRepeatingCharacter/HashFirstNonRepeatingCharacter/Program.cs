using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashFirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            // a green apple
            var str = "a green apple";
            var str2 = "green apple";

            CharFinder finder = new CharFinder();
            //var ch = finder.findFirstNonRepeatingChar(str);

            //Console.WriteLine("The first non repeating character in the string is: " + ch);

            var ch = finder.findFirstRepeatedChar(str2);
            Console.WriteLine("The first repeated character in the string is: " + ch);
        }
    }
}
