
namespace Intermidiate
{

    class Program{

          static void Main(string[] args){
              var post = new Post();
              post.Title = "How to create a varibale";
              post.Description = "Its on how to create a variable";
              post.DateCreated = DateTime.Now;

             post.UpVote();
             post.DownVote();
             post.GetVotes();



            //   var stopwatch =new StopWatch();
            //   try
            //   {
            //     stopwatch.Start();
            //     stopwatch.Start();
            //     stopwatch.Stop();
            //     Console.WriteLine("StopWatch Duration is {0}", stopwatch.duration.Milliseconds);
            //   }
            //   catch (Exception)
            //   {
            //       Console.WriteLine("Timer Already Started");
            //   }
         
        }
      
    }
}