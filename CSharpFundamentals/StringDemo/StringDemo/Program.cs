using System;
using System.Collections.Generic;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text.";
            var summary = StringUtility.SummarizeText(sentence, 20);
            Console.WriteLine(summary);
        }

        

    }
}
