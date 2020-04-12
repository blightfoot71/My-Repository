using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new StopWatch();

            timer.Start();

            Thread.Sleep(1000);

            timer.Stop();

            Console.WriteLine("Duration: " + timer.Duration);

            timer.Start();

            for (var i = 0; i < 1000; i++)
                Thread.Sleep(1);

            timer.Stop();

            Console.WriteLine("Duration: " + timer.Duration);

            timer.Start();

            Thread.Sleep(1000);

            timer.Stop();

            Console.WriteLine("Duration: " + timer.Duration);
            timer.Start();

            Console.WriteLine("Press Enter to stop the timer.");
            Console.Read();

            timer.Stop();

            Console.WriteLine("Duration: " + timer.Duration);

        }
    }
}
