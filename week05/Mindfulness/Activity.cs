using System;
namespace Mindfulness;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.";
        _duration = 30; // default value
    }

    //getter and setters
    public string Name
    {
        get { return _name; }
        set{ _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set{ _description = value; }
    }
    public int Duration
    {
        get { return _duration; }
        set{ _duration = value; }
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
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
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i = (i + 1) % spinner.Count;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
