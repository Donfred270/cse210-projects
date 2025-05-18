// Program.cs
using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Journal class
            Journal myJournal = new Journal();

            bool running = true;
            while (running)
            {
                // Disply the menu
                Console.WriteLine("Welcome to the Journal Program!");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");

                // Asking for user input
                int choice = int.Parse(Console.ReadLine());

                // Perform the action based on the user choice
                switch (choice)
                {
                    case 1:
                        WriteJournal.WriteJournalToFile();  // Call the WriteJournalToFile method
                        break;
                    case 2:
                        DisplayJournal.DisplayJournalEntries(myJournal);  // Call the DisplayJournalEntries method
                        break;
                    case 3:
                        Console.WriteLine("Enter the filename to load the journal:");
                        string loadFile = Console.ReadLine();
                        LoadJournal.LoadJournalFromFile(myJournal);  // Call the LoadJournalFromFile method
                        break;
                    case 4:
                        Console.WriteLine("Enter the filename to save the journal:");
                        string saveFile = Console.ReadLine();
                        SaveJournal.SaveJournalToFile(myJournal);  // Call the SaveJournalToFile method
                        break;
                    case 5:
                        running = false;  // Exit the program
                        Console.WriteLine("Goodbye!");
                        ExitProgram.QuitProgram();  // Call the QuitProgram method to exit cleanly
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
