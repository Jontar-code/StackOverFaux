using System;

namespace StackOverFaux
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = new Post("","");

            if (op._title == null || op._title=="")
            {
                string titleString;
                Console.WriteLine("Enter a title: ");
                titleString = Console.ReadLine();
                op._title = titleString;
            }
            if(op._description==null || op._description=="")
            {
                string descString;
                Console.WriteLine("Enter a Description: ");
                descString = Console.ReadLine();
                op._description = descString;
            }
            Console.Clear();
            var thing = true;
            while (thing)
            {
                
                Console.WriteLine("Title: {0}", op._title);
                Console.WriteLine();
                Console.WriteLine("Description: {0}", op._description);
                Console.WriteLine();
                Console.WriteLine("Total Votes: {0}", op.GetVotes());
                Console.WriteLine();
                Console.WriteLine("To upvote, type 'up'. To downvote, type 'down'.");

                Console.WriteLine();
                Console.WriteLine("To exit, type exit.");

                var input = Console.ReadLine();

                if (input.ToLower() == "up")
                {
                    op.UpVote();
                }
                if (input.ToLower() == "down")
                {
                    op.DownVote();
                }
                if (input.ToLower() == "exit")
                {
                    break;
                }
            }
        }
    }
}
