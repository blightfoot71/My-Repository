using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Without LINQ we had to do this
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);

            // With LINQ we can do this
            // Linq Query Operators
            //var cheaperBooks = from b in books
            //                   where b.Price < 10
            //                   orderby b.Title
            //                   select b.Title;

            // Linq Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);  // cheapBooks is now an emumerable of type string

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
            //Console.WriteLine(book.Title + " " + book.Price);

            var singleBook = books.Single(b => b.Title == "ASP.NET MVC");   // Must have one and only one object that satisfies condition
            var singleBookd = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");   // returns match or default in this case null
            Console.WriteLine(singleBook.Title);

            var firstBook = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(firstBook.Title + " " + firstBook.Price); // also has FirstOrDefault

            var skipBooks = books.Skip(2).Take(3);
            foreach (var skipBook in skipBooks)
                Console.WriteLine(skipBook.Title);

            var count = books.Count();

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);            //returns float Price 12 in this case

            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine(totalPrice);

        }
    }
}
