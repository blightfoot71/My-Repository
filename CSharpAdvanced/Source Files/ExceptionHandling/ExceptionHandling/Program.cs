
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);


            //}
            //// adding the variable ex gives access to the information one gets by hovering over ex in VS
            //catch (DivideByZeroException ex)  // multiple catch block must be in specific to generic order
            //{
            //    Console.WriteLine("You cannot divide by 0.");
            //}
            //catch (ArithmeticException ex)  // otherwise the generic will fire, and we won't see the specific one
            //{

            //}
            //catch (Exception ex)    // It's good to have an argument here to access actual exception
            //{
            //    Console.WriteLine("Sorry, an unexpected error occurred.");
            //}
            //finally
            //{
            //}

            //StreamReader streamReader = null;
            //try
            //{

            //    streamReader = new StreamReader(@"c:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //    throw new Exception("Oops");      // one can just manually throw an exception
            //}
            //catch (Exception)   // Only executed if there is a problem in the try block
            //{
            //    Console.WriteLine("Sorry, an unexpected error occurred.");
            //}
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();     // executed no matter what calls dispose on streamReader to close file handle
            //}

            // A better way of doing the above is this (cleaner)
            //try
            //{
            //    using (var streamReader = new StreamReader(@"c:\file.zip"))  // using will automatically call dispose at the end
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error occurred.");
            //}

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);      // The message created in the other methods gets passed here
            }                                       // This is the only cw
        }
    }
}
