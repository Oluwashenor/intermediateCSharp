namespace Intermidiate{
        public class Person{

        public Person(DateTime birthdate){
            Birthdate = birthdate;
        }
        public DateTime Birthdate{get;private set;}

        public TimeSpan Age{
            get {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan/365;
                return years;
            }
        }

    }
}