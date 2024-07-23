using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.GetPoints();
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus();
            }
            Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string[] data = parts[1].Split(",");

            Goal goal;
            switch (parts[0])
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                    if (bool.Parse(data[3])) ((SimpleGoal)goal).RecordEvent();
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                    for (int j = 0; j < int.Parse(data[5]); j++)
                    {
                        ((ChecklistGoal)goal).RecordEvent();
                    }
                    break;
                default:
                    continue;
            }
            _goals.Add(goal);
        }
    }

    public int GetScore()
    {
        return _score;
    }
}