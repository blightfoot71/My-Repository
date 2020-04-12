using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            post.Title = "My First Post";
            post.Description = "This is so exciting to be able to program in C#.";
            //post.CreationTime = DateTime.Today.AddDays(-2);

            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();

            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.CreationTime);
            Console.WriteLine(post.ViewVotes()); 
        }
    }
}
