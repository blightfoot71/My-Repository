
using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            //DateTime date2;

            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //    date2 = DateTime.Today;

            // The above can be rewritten like below with the null coalescing operator ??
            DateTime date2 = date ?? DateTime.Today;    // if date was value put it in date2 otherwise use Today

            // Below is an example of the tertiary operator.
            // It does the same thing as above just with a bit more code
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date2);


            //Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);

            //DateTime? date = new DateTime(2014, 1, 1);
            //// DateTime date2 = date;       // Produces error because nullable datetime is different than type datetime
            //DateTime date2 = date.GetValueOrDefault();  // Must do it like this
            //DateTime? date3 = date2;    // This works because datetime can be converted to nullable, just not the other way.
        }
    }
}
