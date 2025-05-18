// Entry.cs
using System;
namespace JournalApp;
public class Entry
{
    public string Date { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }

    // Constructeur
    public Entry(string question, string answer)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Question = question;
        Answer = answer;
    }

    // Méthode pour afficher une entrée
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Question: {Question}");
        Console.WriteLine($"Answer: {Answer}\n");
    }
}