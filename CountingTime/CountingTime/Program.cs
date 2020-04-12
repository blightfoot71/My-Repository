using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfResults = 100;
            var upperLimit = 1000;
            int x;
            int y;
            int z;
            int xCubed;
            int yCubed;
            int zCubed;
            bool resultFound;
            var count = 0;

            DateTime start = DateTime.Now;

            for (var k = 1; k <= numberOfResults; k++)
            {
                Console.Write("k = " + k);
                resultFound = false;
                //Parallel.For(0, upperLimit, i =>
                for (int i = 0; i < upperLimit; i++)
                {
                    if (i % 2 == 0)
                        x = ((i - 2 * i) / 2);
                    else
                        x = (i + 1) / 2;

                    xCubed = x * x * x;
                    for (int j = 0; j < upperLimit; j++)
                    {
                        if (i % 2 == 0)
                            y = ((j - 2 * j) / 2);
                        else
                            y = (j + 1) / 2;

                        yCubed = y * y * y;
                        for (int l = 0; l < upperLimit; l++)
                        {
                            if (l % 2 == 0)
                                z = ((l - 2 * l) / 2);
                            else
                                z = (l + 1) / 2;
                            zCubed = z * z * z;
                            if ((xCubed) + (yCubed) + (zCubed) == k)
                            {
                                Console.Write("   X = " + x + ", Y = " + y + ", Z = " + z);
                                Console.WriteLine();
                                resultFound = true;
                                count++;
                                break;
                            }
                        }
                        if (resultFound)
                            break;
                    }

                    if (resultFound)
                        break;
                }
                Console.WriteLine();
            }
            var runTime = DateTime.Now - start;

            Console.WriteLine("Number of results found: " + count);
            Console.WriteLine(upperLimit + " numbers searched");
            Console.WriteLine("Run time = " + runTime);

        }
    }
}
