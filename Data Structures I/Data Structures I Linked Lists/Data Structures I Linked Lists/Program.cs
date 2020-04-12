using System;
using System.Collections.Generic;

namespace Data_Structures_I_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list2 = new List<int>();
            //list2.RemoveAt(10);


            var list = new LinkedList();
            Console.WriteLine(list.size());

            list.addLast(10);
            list.addLast(20);
            list.addLast(30);
            list.addLast(40);
            list.addLast(50);
            list.addLast(60);

            Console.WriteLine(list.indexOf(60));
            Console.WriteLine();

            Console.WriteLine(list.contains(10));
            Console.WriteLine();

            list.print();
            Console.WriteLine();

            //list.removeFirst();
            //list.removeLast();

            list.print();
            Console.WriteLine();
            Console.WriteLine(list.size());
            Console.WriteLine();

            var array = list.toArray();
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            //Console.WriteLine("Reversing the list...");
            //list.reverse();
            //list.print();

            int k = 1;
            Console.WriteLine("The {0}th node from the end is: {1}" , k, list.getkthFromTheEnd(k));

            Console.WriteLine(list.printMiddle());
            Console.WriteLine();

            var list2 = LinkedList.createWithLoop();
            Console.WriteLine(list2.hasLoop());

        }

    }
}
