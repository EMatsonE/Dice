using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            do
            { 

            Console.WriteLine("How many sides do your dice have?");
            int userDice = int.Parse(Console.ReadLine());

            while (userDice < 4)
            {
                Console.WriteLine("Dice have 4 or more sides...");
                userDice = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sweet! Now give them a roll by saying roll!");
            string userInput = Console.ReadLine().ToLower().Trim();

            while (userInput != "roll")
            {
                Console.WriteLine("You...just had to type roll...that's all...");
                userInput = Console.ReadLine().ToLower().Trim();
            }

            var randNumOne = new Random();

            var randNumTwo = new Random();

            Console.WriteLine($"Looks like you rolled {randNumOne.Next(1, userDice)} " +
                $"and {randNumTwo.Next(1, userDice)}!");


            bool isValid = false;

            do
            {
                Console.WriteLine("Would you like to roll again?");
                userInput = Console.ReadLine();
                if (userInput.Trim().ToLower() == "no")
                {
                    playAgain = false;
                    isValid = true;
                }
                else if (userInput.Trim().ToLower() == "yes")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Bruh, it's just a yes or no question...");
                }
            }
            while (isValid == false);
            }
            while (playAgain == true);

            Console.WriteLine("See you next time!!");
        }
    }
}
