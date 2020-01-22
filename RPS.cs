using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string scissors = "";
            string paper = "";
            string rock = "";
            Random rand = new Random();
            int randNum = rand.Next(1, 4);
            if (randNum == 1)
            {
                rock = "rock";
            }
            else if (randNum == 2)
            {
                paper = "paper";
            }
            else
            {
                scissors = "scissors";
            }

            Console.WriteLine("Write Rock, Paper or Scissors");
            string user = Console.ReadLine().ToLower();
            Console.WriteLine("You guessed " + user);

            if (user == "scissors" && randNum == 1)
            {
                Console.WriteLine("Computer chose Rock against " + user + "!" + " You lose");
            }
            else if (user == "scissors" && randNum == 2)
            {
                Console.WriteLine("Computer chose Paper against " + user + "!" + " You Win");
            }
            else if (user == "scissors" && randNum == 3)
            {
                Console.WriteLine("Computer chose Scissors against " + user + "!" + " It's a draw");
            }
            else if (user == "paper" && randNum == 1)
            {
                Console.WriteLine("Computer chose Rock against " + user + "!" + " You Win");
            }
            else if (user == "paper" && randNum == 2)
            {
                Console.WriteLine("Computer chose Paper against " + user + "!" + " It's a draw");
            }
            else if (user == "paper" && randNum == 3)
            {
                Console.WriteLine("Computer chose Scissors against " + user + "!" + " You Lose");
            }
            else if (user == "rock" && randNum == 1)
            {
                Console.WriteLine("Computer chose Rock against " + user + "!" + " It's a draw");
            }
            else if (user == "rock" && randNum == 2)
            {
                Console.WriteLine("Computer chose Rock against " + user + "!" + " You Lose");
            }
            else if (user == "rock" && randNum == 1)
            {
                Console.WriteLine("Computer chose Rock against " + user + "!" + " You Win");
            }
            else if (user != "rock" || user != "scissors" || user != "paper")
            {
                Console.WriteLine("Not a correct answer");
            }

        }
    }
}
