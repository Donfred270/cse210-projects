// WriteJournal.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class WriteJournal
    {
       
        public static void WriteJournalToFile()
        {
            // List of prompts
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            string userChoice = "yes";

            while (userChoice == "yes")
            {
                // random number generator
                Random random = new Random();
                int promptIndex = random.Next(prompts.Count);  
                string selectedPrompt = prompts[promptIndex];  

                // dispay the prompt to the user
                Console.WriteLine("Please respond to the following question:");
                Console.WriteLine(selectedPrompt);

                // gather user input
                string userAnswer = Console.ReadLine();

                // get the current date and time
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // create the entry string
                string entry = $"Date: {currentDate}\nQuestion: {selectedPrompt}\nAnswer: {userAnswer}\n\n";

                Console.WriteLine("\nThank you for your answer! Your entry will be saved.");
                // Specify the file path where the journal will be saved
                string filePath = "journal.txt";

                try
                {
                    // add the entry to the file
                    File.AppendAllText(filePath, entry);

                    // Confirmation message
                    Console.WriteLine("Your journal entry has been saved successfully.");
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"An error occurred while saving your entry: {ex.Message}");
                }

                
                Console.WriteLine("\nWould you like to add another entry? (yes/no)");
                userChoice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Goodbye! Your journal has been saved.");
        }
    }
}
