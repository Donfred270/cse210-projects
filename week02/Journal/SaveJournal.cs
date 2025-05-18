// SaveJournal.cs
using System;
using System.IO;
namespace JournalApp;
public class SaveJournal
{
    // Methode to save the journal to a file
    public static void SaveJournalToFile(Journal journal)
    {
        
        Console.WriteLine("Enter the filename to save the journal:");
        string filename = Console.ReadLine();

       
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Write each entry to the file
                foreach (var entry in journal.Entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Question}|{entry.Answer}");
                }
            }

            Console.WriteLine($"Your journal has been saved to {filename}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }
    }
}
