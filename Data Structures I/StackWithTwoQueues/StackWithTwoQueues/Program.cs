using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithTwoQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackWithTwoQueues();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            for (int i = 0; i < 5; i++)
                Console.WriteLine(stack.Pop());
        }

    }
}
