using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
            Console.WriteLine(FactorialRecursive(4));

        }

        public static int Factorial (int n)
        {
            var factorial = 1;
            for (var i = n; i > 1; i--)
                factorial *= i;
            return factorial;
        }

        public static int FactorialRecursive(int n)
        {
            // Base condition
            if (n == 0)
                return 1;

            return n * FactorialRecursive(n - 1);
        }
    }
}
