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

    public string GetName() => _name;
    public string GetDescription() => _description;
    public string GetPoints() => _points;
}

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }

    public void RecordEvent()
    {
        _isComplete = true;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }
}

public class EternalGoal : Goal
{

    private bool _isComplete;

    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
       
    }

    public void RecordEvent()
    {
        _isComplete = true;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }
}

public class CheckListGoal : Goal
{
    private int _amountCompleted; 
    private int _target; 
    private int _bonus; 

    private bool _isComplete;

    public CheckListGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
       _amountCompleted = amountCompleted; 
       _target = target; 
       _bonus = bonus; 
    }

    public int GetamountCompleted() => _amountCompleted;
    public int GetTarget() => _target;
    public int GetBonus() => _bonus;

    public void RecordEvent()
    {
        _isComplete = true;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

}

public class GoalManager
{
    private int _score;
    private List<Goal> _goals;

    private string name;
    private string description;
    private string points;

    private int amountCompleted; 
    private int target; 
    private int bonus;
    
    public GoalManager(int score)
    {
        _score = score;
        _goals = new List<Goal>();

        name = "";
        description = "";
        points = "";

        amountCompleted = 0;
        target = 0;
        bonus = 0;
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
                    ListGoals();
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
       

        string type = " ";

        while (type != "4")
        {
            Console.WriteLine("The types of goals are: ");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.WriteLine("  4. Go back to the main menu");
            Console.WriteLine("Which type of goal would you like to create? ");

            type = Console.ReadLine();

            switch (type)
            {
                case "1":
                    Console.WriteLine("What is the name of your goal? ");
                    name = Console.ReadLine();

                    Console.WriteLine("What is a short description of it? ");
                    description = Console.ReadLine();

                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                    Console.WriteLine("Simple Goal created!");
                    break;
                case "2":
                    Console.WriteLine("What is the name of your goal? ");
                    name = Console.ReadLine();

                    Console.WriteLine("What is a short description of it? ");
                    description = Console.ReadLine();

                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();

                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    Console.WriteLine("Eternal Goal created!");

                    break;
                case "3":
                    Console.WriteLine("What is the name of your goal? ");
                    name = Console.ReadLine();

                    Console.WriteLine("What is a short description of it? ");
                    description = Console.ReadLine();

                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    points = Console.ReadLine();
                    
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                    target = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    bonus = int.Parse(Console.ReadLine());

                    CheckListGoal checklistGoal = new CheckListGoal(name, description, points, 0, target, bonus);
                    _goals.Add(checklistGoal);
                    Console.WriteLine("Checklist Goal created!");

                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");

        int goalCounter = 0;

        foreach (Goal goal in _goals)
        {   
            goalCounter++;

            Console.WriteLine($"{goalCounter}. [ ] {goal.GetName()} ({goal.GetDescription()}) ---Currently completed: {amountCompleted}/{(goal as CheckListGoal)?.GetTarget() ?? 0}");

            
           
        }
    }

    public static void Main()
    {
        // Instantiate GoalManager and start the program
        GoalManager goalManager = new GoalManager(0);
        goalManager.Start();
    }
}
