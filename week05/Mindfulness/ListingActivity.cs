using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;

        public ListingActivity() : base()
        {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            _count = 0;
        }

        public void Run()
        {
            DisplayStartingMessage();

            // Override the description for this specific activity
            Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            Console.WriteLine($"\n{Description}");

            Console.Write("\nHow long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();
            int listingDuration;

            // Validate user input
            while (!int.TryParse(input, out listingDuration) || listingDuration <= 0)
            {
                Console.Write("Please enter a valid duration (in seconds): ");
                input = Console.ReadLine();
            }

            // Use the Duration property inherited from Activity
            Duration = listingDuration;

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(5);

            string prompt = GetRandomPrompt();
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine("You may begin in: ");
            ShowCountDown(5);

            List<string> responses = GetListFromUser();
            _count = responses.Count;

            Console.WriteLine($"\nYou listed {_count} items.");

            DisplayEndingMessage();
            ShowSpinner(3);

            Console.WriteLine($"\nYou have completed another {Duration} seconds of the Listing Activity.");
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }

        private List<string> GetListFromUser()
        {
            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    items.Add(input);
            }

            return items;
        }
    }
}
