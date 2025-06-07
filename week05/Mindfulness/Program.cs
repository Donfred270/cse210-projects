using System;
using System.Dynamic;
namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Name = "Breathing Activity";
                        breathing.Description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.";
                        breathing.DisplayStartingMessage();

                        Console.WriteLine("\nHow long, in seconds, would you like for your session?");
                        string input = Console.ReadLine();
                        int duration;

                        while (!int.TryParse(input, out duration) || duration <= 0)
                        {
                            Console.WriteLine("Veuillez entrer une durée valide (en secondes) : ");
                            input = Console.ReadLine();
                        }

                        breathing.Duration = duration;

                        Console.Clear();
                        Console.WriteLine("Get ready...");
                        breathing.ShowSpinner(5);
                        breathing.Run();
                        breathing.ShowSpinner(5);

                        Console.WriteLine($"\nYou have completed {breathing.Duration} seconds of the Breathing Activity.");
                        Thread.Sleep(5000);
                        Console.WriteLine("Press any key to return to the menu...");
                        Console.ReadKey();
                        break;

                    case "2":
                        ReflectingActivity reflecting = new ReflectingActivity();
                        //set the name of the activity to reflecting activity
                        reflecting.Name = "Reflecting Activity";

                        //start running the program
                        reflecting.Run();
                        Console.WriteLine("Press any key to return to the menu...");
                        Console.ReadKey();
                        break;

                    case "3":
                        ListingActivity listing = new ListingActivity();
                        // set the name of the activity to listing activiy
                        listing.Name = "Listing Activity";
                        listing.Run();
                        Console.WriteLine("Press any key to return to the menu...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye!");
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}