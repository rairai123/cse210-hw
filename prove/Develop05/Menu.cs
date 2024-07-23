public class Menu
{
    private GoalManager _goalManager;

    public Menu()
    {
        _goalManager = new GoalManager();
    }

    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4","5","6"};
        while(response != "6")
        {
            while(!options.Contains(response))
            {
                Console.WriteLine($"\nYou have {_goalManager.GetScore()} points.\n");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch(response)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    _goalManager.DisplayGoals();
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
                    Console.WriteLine("Thank you for using the Eternal Quest program!");
                    break;
            }
            response = "";
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine() ?? String.Empty;

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? String.Empty;

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine() ?? String.Empty;

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine() ?? "0");

        Goal goal;
        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine() ?? "0");
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goalManager.AddGoal(goal);
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() ?? String.Empty;
        _goalManager.SaveGoals(filename);
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() ?? String.Empty;
        _goalManager.LoadGoals(filename);
    }

    private void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        _goalManager.DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine() ?? "0") - 1;
        _goalManager.RecordEvent(index);
    }
}