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