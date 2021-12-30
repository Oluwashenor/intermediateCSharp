namespace Intermidiate
{


// Exercise 2: Design a StackOverflow Post
// Design a class called Post. This class models a StackOverflow post. It should have properties
// for title, description and the date/time it was created. We should be able to up-vote or down-vote
// a post. We should also be able to see the current vote value. In the main method, create a post,
// up-vote and down-vote it a few times and then display the the current vote value.
// In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
// and down-voting. You should not give the ability to set the Vote property from the outside,
// because otherwise, you may accidentally change the votes of a class to 0 or to a random
// number. And this is how we create bugs in our programs. The class should always protect its
// state and hide its implementation detail.

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