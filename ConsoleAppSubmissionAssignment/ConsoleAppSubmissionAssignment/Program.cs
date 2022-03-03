using System;

namespace ConsoleAppSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displays question to user
            Console.WriteLine("What team won the Super Bowl this past 2021 NFL season?");
            //identifies string with variable name given
            string nflTeam = Console.ReadLine();
            //creates a boolean logic statement declaring what the correct "answer"/string is
            bool isGuessed = nflTeam == "Rams";

            //begins our "do statement" 
            do
            {
                //within our "do statement" our "switch statement" is introduced giving different responses
                // based on answers given by user, including a default answer
                switch (nflTeam)
                {
                    case "Buccaneers":
                        Console.WriteLine("You guessed the Buccaneers. Try again.");
                        Console.WriteLine("Guess another team?");
                        nflTeam = Console.ReadLine();
                        break;
                    case "Chiefs":
                        Console.WriteLine("You guessed the Chiefs. Try again.");
                        Console.WriteLine("Guess another team?");
                        nflTeam = Console.ReadLine();
                        break;
                    case "Bills":
                        Console.WriteLine("You guessed the Bills. Try again.");
                        Console.WriteLine("Guess another team?");
                        nflTeam = Console.ReadLine();
                        break;
                    case "Rams":
                        Console.WriteLine("You guessed the Rams. That is the correct team!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You are wrong. Select another team.");
                        Console.WriteLine("Guess another team?");
                        nflTeam = Console.ReadLine();
                        break;
                }
            }
            //our "while statement" is given 
            while (!isGuessed);

            Console.Read();
        }
    }
}
   
