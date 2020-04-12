using System;
using System.IO;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\Projects\CSarpFundamentals\HelloWorld.sln";

            var dotIndex = path.IndexOf(".");
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Ext: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
