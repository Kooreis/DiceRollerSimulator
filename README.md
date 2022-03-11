# Python Documentation

# Dice Rolling Simulator

This is a simple Python script that simulates the rolling of a pair of dice. The script will generate and print two random numbers between 1 and 6 (inclusive), simulating the roll of two dice. The user is then asked if they would like to roll the dice again.

## Script Explanation

The script begins by importing the `random` module, which is a built-in Python library used to generate pseudo-random numbers. This module is used in this script to generate the random numbers that simulate the dice roll.

The script then enters an infinite loop, which will continue to execute until the user decides to stop rolling the dice. 

Within this loop, the script first prints a message to the console indicating that the dice are being rolled. It then generates and prints two random numbers between 1 and 6, simulating the roll of two dice. 

After the dice roll, the script prompts the user to decide whether they want to roll the dice again. If the user enters anything other than 'Y' or 'y', the script will break out of the loop and end.

## Libraries Used

- `random`: This is a built-in Python library used to generate pseudo-random numbers. In this script, it is used to generate the random numbers that simulate the dice roll. The `randint` function is used, which generates a random integer within the specified range (in this case, between 1 and 6, inclusive).

## How to Run

To run this script, simply execute the Python file in your terminal or command prompt. You will be prompted to decide whether you want to roll the dice again after each roll. To stop rolling, simply enter anything other than 'Y' or 'y' when prompted.

---

# C# Documentation

# Dice Roller Simulator

This is a simple console application written in C# that simulates the rolling of a dice. The user can specify the number of sides for the dice, and the program will generate a random number within that range. The user can continue to roll the dice as many times as they want.

## Code Explanation

The script uses the `System` namespace, which is a fundamental library in C#. It provides classes and functionalities that are used in a wide variety of applications. In this script, it is used for console input/output and generating random numbers.

Here is a brief explanation of the main parts of the script:

- `Random random = new Random();` - This line creates a new instance of the `Random` class, which is used to generate random numbers.

- `Console.WriteLine("Welcome to Dice Roller Simulator!");` - This line prints a welcome message to the console.

- `while (true)` - This line starts an infinite loop, which continues until the user decides to stop rolling the dice.

- `Console.WriteLine("Please enter the number of sides for the dice:");` - This line prompts the user to enter the number of sides for the dice.

- `if (int.TryParse(userInput, out int numberOfSides))` - This line attempts to parse the user's input as an integer. If the parsing is successful, the number of sides for the dice is set to the parsed value.

- `int diceRoll = random.Next(1, numberOfSides + 1);` - This line generates a random number between 1 and the number of sides for the dice.

- `Console.WriteLine("Would you like to roll again? (yes/no)");` - This line asks the user if they want to roll the dice again.

- `if (userInput != "yes")` - This line checks if the user's input is not "yes". If it's not, the loop is broken and the program ends.

- `Console.WriteLine("Thank you for using Dice Roller Simulator. Goodbye!");` - This line prints a goodbye message to the console.

## How to Run

To run this script, you need a C# compiler. You can use the one that comes with the .NET SDK. Simply navigate to the directory containing the script and run the following command:

```
dotnet run
```

This will compile and run the script. You can then follow the prompts in the console to roll the dice.

---

# Java Documentation

# Dice Roller Simulator

This is a simple Java program that simulates the rolling of a dice. The program will continue to roll the dice until the user decides to stop.

## How it works

The program uses a `do-while` loop to continuously roll a dice. After each roll, the program will ask the user if they want to roll again. If the user inputs "yes", the program will roll the dice again. If the user inputs "no", the program will stop rolling the dice and terminate.

## Imported Libraries

The program uses two imported libraries:

1. `java.util.Random`: This library is used to generate a random number between 1 and 6, simulating the roll of a dice. The `nextInt(6)` method is used to generate a random integer between 0 (inclusive) and 6 (exclusive), and then 1 is added to the result to get a number between 1 and 6.

2. `java.util.Scanner`: This library is used to get the user's input. The `nextLine()` method is used to read the user's input as a string. The `equalsIgnoreCase()` method is used to compare the user's input to "yes" and "no", ignoring the case of the input.

## Usage

To use the program, simply run it and follow the prompts. After each roll, you will be asked if you want to roll again. Input "yes" to roll again, or "no" to stop.

## Conclusion

This program is a simple demonstration of how to use loops and user input in Java. It also shows how to use the `Random` and `Scanner` libraries to generate random numbers and get user input, respectively.

---
