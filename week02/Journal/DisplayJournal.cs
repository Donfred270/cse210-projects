// DisplayJournal.cs
using System;
using System.Collections.Generic;
namespace JournalApp;
public class DisplayJournal
{
    public static void DisplayJournalEntries(Journal journal)
    {
        //check if the journal has any entries
        if (journal.Entries.Count == 0)
        {
            Console.WriteLine("No journal entries available.");
        }
        else
        {
            // Iterate through each entry in the journal and display it
            foreach (var entry in journal.Entries)
            {
                entry.Display();
            }
        }
    }
}