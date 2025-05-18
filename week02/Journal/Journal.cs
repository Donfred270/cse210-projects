// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;
namespace JournalApp;
public class Journal
{
    public List<Entry> Entries { get; set; }

    // Constructeur
    public Journal()
    {
        Entries = new List<Entry>();
    }

    // Ajouter une nouvelle entrée
    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    // Afficher toutes les entrées du journal
    public void DisplayJournal()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No journal entries available.");
        }
        else
        {
            foreach (var entry in Entries)
            {
                entry.Display();
            }
        }
    }

    // Sauvegarder le journal dans un fichier
    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Question}|{entry.Answer}");
            }
        }

        Console.WriteLine("The journal has been saved to the file.");
    }

    // Charger le journal depuis un fichier
    public void LoadJournal(string filename)
    {
        Entries.Clear();  // Effacer les entrées existantes

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        var entry = new Entry(parts[1], parts[2])
                        {
                            Date = parts[0]
                        };
                        Entries.Add(entry);
                    }
                }
            }

            Console.WriteLine("Journal has been loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
