using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_I_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefghijklmnopqrstuvwxyz";
            //String str = null;

            var reverser = new StringReverser();
            var result = reverser.reverse(str);
            

            Console.WriteLine(result);

            String str2 = "(1 + 2)";

            var expresion = new StringReverser();
            var result2 = expresion.IsBalanced(str2);
            Console.WriteLine(result2);


        }
    }
}
