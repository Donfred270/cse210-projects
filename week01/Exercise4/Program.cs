using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
       List<int> number = new List<int>();
        int userInput = 0; // Initialize userInput to 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        // Prompt the user to enter numbers until they enter 0
        // The loop continues until the user enters 0
       do{
        Console.WriteLine("Enter number:");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int num)) // Check if the input is a valid integer
        {
            Console.WriteLine("Please enter a valid number.");
        }
        else
        {
           userInput = int.Parse(input); // Parse the input to an integer
           number.Add(userInput); // Add the number to the list
        }
       }while(userInput != 0);
           
        Console.WriteLine("The numbers you entered are: "+ string.Join(", ", number)); // Print the list of numbers
        Console.WriteLine("The sum of the numbers is: " + number.Sum()); // Print the sum of the numbers
        Console.WriteLine("The average of the numbers is: " + number.Average()); // Print the average of the numbers
        Console.WriteLine("The largest number is: " + number.Max()); // Print the maximum number
        List<int> sortedList = number.OrderBy(x => x).ToList(); // Sort the list in ascending order
        Console.WriteLine("The sorted list is: " + string.Join(", ", sortedList)); // Print the sorted list
        Console.WriteLine("The smallest number is: " + number.Min()); // Print the minimum number
    }
}