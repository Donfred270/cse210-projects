// LoadJournal.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class LoadJournal
    {
        // Method to load journal entries from a file
        public static void LoadJournalFromFile(Journal journal)
        {
            // Ask the user for the filename to load
            Console.WriteLine("Enter the filename to load the journal:");
            string filename = Console.ReadLine();

            // Check if the file exists before trying to load it
            if (File.Exists(filename))
            {
                try
                {
                    // Clear the existing entries in the journal
                    journal.Entries.Clear();

                    // Use StreamReader to read the file and load the entries
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Split each line by the separator '|'
                            var parts = line.Split('|');
                            if (parts.Length == 3)
                            {
                                // Create a new entry with the date, question, and answer
                                var entry = new Entry(parts[1], parts[2])
                                {
                                    Date = parts[0]  // Add the date to the entry
                                };
                                // Add the entry to the journal
                                journal.AddEntry(entry);
                            }
                        }
                    }

                    Console.WriteLine("Journal has been loaded successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
