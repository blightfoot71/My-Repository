using ConsoleApp1.Math;
using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var calculator = new Calculator();
            for (var i = 0; i < 20000; i++)
            {
                var result = i + 2;
                Console.WriteLine(result);
            }
        }

    }
}