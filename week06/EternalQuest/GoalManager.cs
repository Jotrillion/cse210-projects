using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }
    public GoalManager()
    {
        _goals = new List<Goal>();
    }
    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        Console.WriteLine("You are an adventurer on a quest to complete various goals and earn points.");
        Console.WriteLine("Choose from the following options:");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record an event");
        Console.WriteLine("6. Quit");
        string choice = Console.ReadLine();
        while (choice != "6")
        {
            DisplayTotalPoints();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
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
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Choose from the following options:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Quit");
            choice = Console.ReadLine();
        }
        Console.WriteLine("Thank you for playing Eternal Quest!");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        // Group and display EternalGoals
        var eternalGoals = _goals.FindAll(g => g is EternalGoal);
        if (eternalGoals.Count > 0)
        {
            Console.WriteLine("Eternal Goals:");
            int i = 1;
            foreach (var goal in eternalGoals)
            {
                Console.WriteLine($"  {i}. {goal.GetDetailsString()}");
                i++;
            }
            Console.WriteLine();
        }

        // Group and display SimpleGoals
        var simpleGoals = _goals.FindAll(g => g is SimpleGoal);
        if (simpleGoals.Count > 0)
        {
            Console.WriteLine("Simple Goals:");
            int i = 1;
            foreach (var goal in simpleGoals)
            {
                Console.WriteLine($"  {i}. {goal.GetDetailsString()}");
                i++;
            }
            Console.WriteLine();
        }

        // Group and display ChecklistGoals
        var checklistGoals = _goals.FindAll(g => g is ChecklistGoal);
        if (checklistGoals.Count > 0)
        {
            Console.WriteLine("Checklist Goals:");
            int i = 1;
            foreach (var goal in checklistGoals)
            {
                Console.WriteLine($"  {i}. {goal.GetDetailsString()}");
                i++;
            }
            Console.WriteLine();
        }

        var dailyGoals = _goals.FindAll(g => g is DailyGoal);
        if (dailyGoals.Count > 0)
        {
            Console.WriteLine("Daily Goals:");
            int i = 1;
            foreach (var goal in dailyGoals)
            {
                Console.WriteLine($"  {i}. {goal.GetDetailsString()}");
                i++;
            }
            Console.WriteLine();
        }

        // DailyGoal type not supported/defined; removed to avoid compile errors.
    }
    public void CreateGoal()
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Daily Goal");
        string choice = Console.ReadLine();
        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter a short description of the goal:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter the points associated with this goal:");
        string points = Console.ReadLine();
        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter the number of times this goal needs to be completed:");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bonus points for completing this goal:");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints, 0));
                break;
            case "4":

                _goals.Add(new DailyGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Choose the goal you accomplished:");
        ListGoalNames();
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice. Event not recorded.");
            return;
        }
        Goal selectedGoal = _goals[choice - 1];
        if (selectedGoal.IsComplete())
        {
            Console.WriteLine("This goal is already complete.");
            return;
        }
        selectedGoal.RecordEvent();
        _score += int.Parse(selectedGoal.GetPoints());
        if (selectedGoal.IsComplete() && selectedGoal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonusPoints();
                Console.WriteLine($"Congratulations! You completed the checklist goal and earned a bonus of {checklistGoal.GetBonusPoints()} points!");
            }
        }
        Console.WriteLine($"You earned {selectedGoal.GetPoints()} points!");
    }
    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save your goals:");
        string filename = Console.ReadLine();
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load your goals:");
        string filename = Console.ReadLine();
        if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("File not found. Goals not loaded.");
            return;
        }
        _goals.Clear();
        using (System.IO.StreamReader file = new System.IO.StreamReader(filename))
        {
            _score = int.Parse(file.ReadLine());
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                switch (type)
                {
                    case "SimpleGoal":
                        if (parts.Length >= 5)
                        {
                            var goal = new SimpleGoal(parts[1], parts[2], parts[3]);
                            if (parts[4].ToLower() == "true")
                            {
                                
                                goal.SetComplete(true);
                            }
                            _goals.Add(goal);
                        }
                        else
                        {
                            Console.WriteLine("Invalid SimpleGoal data. Goal not loaded.");
                        }
                        break;
                    case "EternalGoal":
                        if (parts.Length >= 4 )
                        {
                            _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid EternalGoal data. Goal not loaded.");
                        }
                        break;
                    case "ChecklistGoal":
                        if (parts.Length >= 7
                           
                            && int.TryParse(parts[4], out int currentCount)
                            && int.TryParse(parts[5], out int targetCount)
                            && int.TryParse(parts[6], out int bonusPoints))
                        {
                            _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], targetCount, bonusPoints, currentCount));
                        }
                        else
                        {
                            Console.WriteLine("Invalid ChecklistGoal data. Goal not loaded.");
                        }
                        break;
                    case "DailyGoal":
                        if (parts.Length >= 5 )
                        {
                            bool isComplete = parts[4].ToLower() == "true";
                            var goal = new DailyGoal(parts[1], parts[2], parts[3]);
                            goal.SetComplete(isComplete);
                            _goals.Add(goal);
                        }
                        else
                        {
                            Console.WriteLine("Invalid DailyGoal data. Goal not loaded.");
                        }
                        break;
                }
            }
            ListGoalDetails();
            Console.WriteLine("Goals loaded successfully.");
        }
    }
    public int GetScore()
    {
        return _score;
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public void DisplayTotalPoints()
    {
        int total = _score;

        // Add bonus points for completed ChecklistGoals
        foreach (Goal goal in _goals)
        {
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                total += checklistGoal.GetBonusPoints();
            }
        }

        Console.WriteLine($"Total Points: {total}");
    }
}