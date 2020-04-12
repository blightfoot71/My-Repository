using System;

namespace Data_Structures_I_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Array(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            numbers.insert(50);
            numbers.insert(60);

            var numbers2 = new int[] { 15, 25, 30, 40, 55, 65, 60 };


            // numbers.removeAt(2);

            // Console.WriteLine(numbers.indexOf(400));
            //Console.WriteLine("The maximum value is " + numbers.max());

            numbers.print();
            Console.WriteLine();
            
            //numbers.intersect(numbers2).print();
            //Console.WriteLine();

            //numbers.reverse();
            //numbers.print();

            numbers.intsertAt(65, 6);
            numbers.print();




        }
    }
}
