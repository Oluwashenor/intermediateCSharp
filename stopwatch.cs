namespace Intermidiate
{

//     Exercise 1: Design a Stopwatch
// Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
// provide two methods: Start and Stop. We call the start method first, and the stop method next.
// Then we ask the stopwatch about the duration between start and stop. Duration should be a
// value in TimeSpan. Display the duration on the console.
// We should also be able to use a stopwatch multiple times. So we may start and stop it and then
// start and stop it again. Make sure the duration value each time is calculated properly.
// We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
// start time). So the class should throw an InvalidOperationException if its started twice.

    public class StopWatch{

        private DateTime start;
        private DateTime end;

        private DateTime initialDateTime;

        public TimeSpan duration { 
            get {
                var difference = end - start;
                return difference;
            } 
         }
        public void Start(){
            Console.WriteLine("Starting");
            if(start != initialDateTime )
                throw new ArgumentNullException("StopWatch Already Started");
            start = DateTime.Now;
            Console.WriteLine("Start Time {0}", start);

        }

        public void Stop(){
            Console.WriteLine("Stopping");
            end = DateTime.Now;
        }
    }
}