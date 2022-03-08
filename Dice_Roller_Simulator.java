```java
import java.util.Random;
import java.util.Scanner;

public class DiceRollerSimulator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();
        String userInput = "";

        do {
            System.out.println("Rolling the dice...");
            System.out.println("You rolled a " + (random.nextInt(6) + 1));
            System.out.println("Would you like to roll again? (yes/no)");
            userInput = scanner.nextLine();
        } while(userInput.equalsIgnoreCase("yes"));

        System.out.println("Thank you for using Dice Roller Simulator. Goodbye!");
        scanner.close();
    }
}
```