using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        string userName = "";
        int userNumber;
        int numberSquare;

        DisplayWelcome();  // welcoming message
        PromptUserName(ref userName);  // prompt the user for their name
        userNumber = PromptUserNumber();  // prompt the user for their favorite number
        numberSquare = SquareNumber(userNumber);  // compute the square of the number
        
        //display the result
        DisplayResult(userName, numberSquare);
    }

    // Display a welcome message
    // This method does not return anything
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Ask the user for their name
    static void PromptUserName(ref string userName)
    {
        while (string.IsNullOrEmpty(userName))  // check if the name is empty
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
        }
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
        }
        Console.WriteLine($"Hello, {userName}!");
    }

    // asj the user for their favorite number
    // and return it
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());  // read the number from the console
        return userNumber;
    }

    // Compute the square of the number
    static int SquareNumber(int userNumber)
    {
        int numberSquare = userNumber * userNumber;  // compute the square of the number
        Console.WriteLine($"The square of {userNumber} is {numberSquare}");
        return numberSquare;  // Return hte square of the number	
    }

    //display result
    static void DisplayResult(string userName, int numberSquare)
    {
        Console.WriteLine($"Hello {userName}, the square of your number is {numberSquare}");
    }
    
}