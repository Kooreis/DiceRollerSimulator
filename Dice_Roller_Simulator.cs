```CSharp
using System;

namespace DiceRollerSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string userInput = "";

            Console.WriteLine("Welcome to Dice Roller Simulator!");

            while (true)
            {
                Console.WriteLine("Please enter the number of sides for the dice:");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int numberOfSides))
                {
                    int diceRoll = random.Next(1, numberOfSides + 1);
                    Console.WriteLine($"You rolled a {diceRoll}!");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine("Would you like to roll again? (yes/no)");
                userInput = Console.ReadLine().ToLower();

                if (userInput != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using Dice Roller Simulator. Goodbye!");
        }
    }
}
```