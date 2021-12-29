namespace Intermidiate
{
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