namespace Intermidiate
{
    public class Post{
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        private int AllVotes { get {
            return votes;
        } }

        private int votes;

        public void DownVote(){
            votes -= 1;
        }

        public void UpVote(){
            votes += 1;
        }

        public void GetVotes(){
            Console.WriteLine("Total Number of Votes is {0}", AllVotes);
        }
    }
}