using System;
namespace Mindfulness;

public class Activity
{
    private string _name;
    private string _description;
    private string _duration;

    //constructor
    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //methode for dispay the welcome message
    public void DisplayStartingMessage()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!!");
    }
   public void ShowSpinner(int seconds)
{
    List<string> spinner = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

    int i = 0;
    DateTime endTime = DateTime.Now.AddSeconds(seconds);

    while (DateTime.Now < endTime)
    {
        string s = spinner[i];
        Console.Write(s);
        Thread.Sleep(200);
        Console.Write("\b \b"); 

        i++;
        if (i >= spinner.Count)
        {
            i = 0;
        }
    }
}
}