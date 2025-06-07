using System;
using System.Collections.Generic;
namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity() : base()
        {
            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        public void Run()
        {
            DisplayStartingMessage();

            Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            Console.WriteLine($"\n{Description}");

            Console.Write("\nHow long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();
            int reflectDuration;

            // Vérifie que l'utilisateur entre un nombre valide
            while (!int.TryParse(input, out reflectDuration) || reflectDuration <= 0)
            {
                Console.Write("⛔ Veuillez entrer une durée valide (en secondes) : ");
                input = Console.ReadLine();
            }

            Duration = reflectDuration;

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(5);

            DisplayPrompt();
            Console.Clear();
            DisplayQuestions();

            DisplayEndingMessage();
            ShowSpinner(3);

            Console.WriteLine($"\nYou have completed another {Duration} seconds of the reflecting Activity.");
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }

        private string GetRandomQuestion()
        {
            Random rand = new Random();
            int index = rand.Next(_questions.Count);
            return _questions[index];
        }

        private void DisplayPrompt()
        {
            Console.WriteLine("Consider the following prompt: ");
            string prompt = GetRandomPrompt();
            Console.WriteLine($"\n--- {prompt} ---");

            Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");

            // Attendre uniquement une touche Entrée (vide)
            string input = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(input))
            {
             Console.WriteLine("⛔ You must press Enter to continue.");
                input = Console.ReadLine();
            }

            Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
        }

        private void DisplayQuestions()
        {
            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                string question = GetRandomQuestion();
                Console.WriteLine($"\n> {question}");
                ShowSpinner(5);
            }
        }
    }
}
