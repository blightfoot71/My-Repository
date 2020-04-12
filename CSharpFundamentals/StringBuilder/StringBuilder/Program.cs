using System;
using System.Text;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder("Hello World");

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            // Or because Append returns type StringBuilder method can be chained together
            //builder.Append('-', 10)
            //       .AppendLine()
            //       .Append("Header")
            //       .AppendLine()
            //       .Append('-', 10);


            // The following methods can also be chained together as well.
            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            // Can access StringBuilder just like array or string
            Console.WriteLine("First Char: " +builder[0]);

        }
    }
}
