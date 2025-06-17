// Program.cs
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private int _experience;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _experience = 0;
    }

    public void Start()
    {
        LoadGoals();
        
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    DisplayPlayerInfo();
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nEternal Quest Program");
        Console.WriteLine("---------------------");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Display Player Info");
        Console.WriteLine("7. Quit");
        Console.Write("Select an option: ");
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        if (_goals.Count == 0) return;

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            int pointsEarned = _goals[goalNumber].RecordEvent();
            _score += pointsEarned;
            _experience += pointsEarned;
            CheckLevelUp();
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void CheckLevelUp()
    {
        int expNeeded = _level * 1000;
        if (_experience >= expNeeded)
        {
            _level++;
            _experience -= expNeeded;
            Console.WriteLine($"\nLEVEL UP! You are now level {_level}!");
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
        Console.WriteLine($"Level: {_level}");
        Console.WriteLine($"Experience: {_experience}/{_level * 1000}");
        Console.WriteLine($"Total Goals: {_goals.Count}");
        Console.WriteLine($"Completed Goals: {_goals.FindAll(g => g.IsComplete()).Count}");
    }

    private void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_level);
            outputFile.WriteLine(_experience);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");

        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);
        _experience = int.Parse(lines[2]);

        for (int i = 3; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    var simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete) simpleGoal.RecordEvent();
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "ChecklistGoal":
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);
                    var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int j = 0; j < amountCompleted; j++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}