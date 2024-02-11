using System;
using System.Collections.Generic;

public class Goal
{
    private string _name;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
}

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
}

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals ?? new List<Goal>();
        _score = score;
    }

    public void Start()
    {
        string choice = " ";

        while (choice != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            // Get user input
            choice = Console.ReadLine();

            // Create and run the chosen activity
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    // Implement code for listing goals
                    break;
                case "3":
                    // Implement code for saving goals
                    break;
                case "4":
                    // Implement code for loading goals
                    break;
                case "5":
                    // Implement code for recording events
                    break;
                case "6":
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        string types = " ";

        while (types != "4")
        {
            Console.WriteLine("The types of goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Which type of goal would you like to create? ");

            types = Console.ReadLine();

            switch (types)
            {
                case "1":
                    Console.WriteLine("Simple Goal: ");
                    // Implement code for creating a simple goal
                    break;
                case "2":
                    Console.WriteLine("Eternal Goal: ");
                    // Implement code for creating an eternal goal
                    break;
                case "3":
                    Console.WriteLine("Checklist Goal: ");
                    // Implement code for creating a checklist goal
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public static void Main()
    {
        // Instantiate GoalManager and start the program
        GoalManager goalManager = new GoalManager(new List<Goal>(), 0);
        goalManager.Start();
    }
}
