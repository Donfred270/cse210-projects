using System;
using System.Threading;
using System.Collections.Generic;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base()
        {
        }

        public void Run()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine();
                Console.Write("\nBreathe in...");
                ShowCountDown(5);
                Console.WriteLine();
                Console.Write("Now breathe out...");
                ShowCountDown(5);
                Console.WriteLine("\n");
            }

            DisplayEndingMessage();
        }
    }
}
