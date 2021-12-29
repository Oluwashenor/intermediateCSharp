
namespace Intermidiate
{

    class Program{

          static void Main(string[] args){
              var stopwatch =new StopWatch();
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


        // FOR INDEXER
        //   var cookie = new HttpCookie();
        //   cookie["name"] = "Mosh";
        //   Console.WriteLine(cookie["name"]);
        
        // static void UsePoint(){
        //       try
        // {
        //        var point = new Point(10,20);
        // point.Move(null);
        // Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

        // point.Move(100,200);
        //  Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
        // }
        // catch (Exception)
        // {
            
        //    Console.WriteLine("An unxpected error occured");
        // }
      
        // }

        // static void UseParams(){
            
        // var calculator = new Calculator(); 
        // Console.WriteLine(calculator.Add(1,3));
        // Console.WriteLine(calculator.Add(1,3, 5));   
            
      
        // }

      
    }
}