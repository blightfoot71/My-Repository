using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_I_Stacks_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine(stack.Peek());

            stack.Push(40);

            //Console.WriteLine(stack.Peek());

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }
}
