using System;

class Program
{
    static void Main(string[] args)
    {
        play(); // Call the play method to start the game
    }

    static void  play() // Method to play the guessing game
    // The method generates a random number and prompts the user to guess it
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101); // Generates a random number between 1 and 10 (inclusive)
        int guess = 0;
        int test = 0; // Initialize try counter
        string replay = "y";
        do
        {
             test++; // Increment try counter
            Console.WriteLine("What is the magic number between 1 - 10? ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out guess)) // Check if the input is a valid integer
            {
                Console.WriteLine("Please enter a valid number.");
            }
            
            else if (guess < 1 || guess > 101) // Check if the guess is within the valid range
            {
                Console.WriteLine("Please enter a number between 1 and 10.");
            }
            else if (guess < number)
            {
                Console.WriteLine("too low!, try again.");
            }
            else if (guess>number)
            {
                Console.WriteLine("too high!, try again");
            }
            else
            {
                Console.WriteLine("You guesses it, congratulations!");
                Console.WriteLine($"You took {test} tries to guess the number.");
                Console.WriteLine($"The magic number was {number}.");
                Console.WriteLine("Do you want to play again? (yes/no)");
                replay = Console.ReadLine().ToLower(); // Convert input to lowercase for consistency
                if (replay == "yes" || replay == "y")
                {
                   play(); // Restart the game by calling Main again
                }
                else if (replay == "no" || replay == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    break; // Exit the loop and end the game
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }while(guess != number);
    }
}