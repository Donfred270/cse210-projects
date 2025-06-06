using System;
using System.Threading;
using System.Collections.Generic;
namespace Mindfulness;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);

            Console.Write("Breathe out... ");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }
}
