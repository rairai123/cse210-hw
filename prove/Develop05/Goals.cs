using System.IO;
using System.Collections.Generic;
public class Goals
{
    List<Create> create = new List<Create>();

    public void goalInput(Create createGoal)
    {
        create.Add(createGoal);
    }

    public void Display()
    {
        foreach (Create c in create)
        {
            Console.WriteLine($"[ ] {c._name}, {c._desc}, {c._points}");
        }
    }
    
    public void goalSave()
    {
        string fileName = "";
        Console.WriteLine("Please create a file name for your goals to be saved. ");
        fileName = Console.ReadLine() ?? String.Empty;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Create c in create)
            {
                outputFile.WriteLine($"{c._name},{c._desc},{c._points}");
            }
        }
    }

    public void goalFind()
    {
        Console.WriteLine("What is the filename for the goal? ");
        string findGoal = Console.ReadLine() ?? String.Empty;
        string fileName = findGoal;
        string [] lines = System.IO.File.ReadAllLines(fileName);
        var pieces = new List<string>();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            var newCreate = new Create(parts[0],parts[1],Convert.ToInt32(parts[2]));
            create.Add(newCreate);
        }
    }

    public void RecordEvent()
    {
        int x = 1;
        Console.WriteLine("Your Goals are: ");
        foreach (Create c in create)
        {
            Console.WriteLine($"{x}. {c._name}");
            x++;
        }
        Console.WriteLine("Which goal did you accomplish? ");
        string response = Console.ReadLine() ?? String.Empty;
        Console.WriteLine($"Congratulations! You have completed goal {response}");

    }
}