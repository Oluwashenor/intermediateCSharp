
namespace Intermidiate
{

    class Program
    {

        // This file contains the usuage for both exercises i did.
        // Thier respective files can be found on stopwatch.cs and post.cs and thier questions are also there 
        // Created below are two methods for thier usage.

        static void Main(string[] args)
        {

        }

        static void UsePost()
        {
            var post = new Post();
            post.Title = "How to create a varibale";
            post.Description = "Its on how to create a variable";
            post.DateCreated = DateTime.Now;

            post.UpVote();
            post.DownVote();
            post.GetVotes();
        }

        static void UseStopWatch()
        {
            var stopwatch = new StopWatch();
            try
            {
                stopwatch.Start();
                stopwatch.Start();
                stopwatch.Stop();
                Console.WriteLine("StopWatch Duration is {0}", stopwatch.duration.Milliseconds);
            }
            catch (Exception)
            {
                Console.WriteLine("Timer Already Started");
            }

        }

    }
}