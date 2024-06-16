public class Reflect : Activity
{
    List<string> _prompt = new List<string>();
    List<string> _prompt1 = new List<string>();
    public void GetRandomPrompt1()
    {
        string question;
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0,_prompt.Count);
        question = _prompt[num];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void GetRandomPrompt2()
    {
        string question2;
        Random r = new Random();
        int num1 = r.Next(0,_prompt1.Count);
        question2 = _prompt1[num1];
        Console.WriteLine($"> {question2}");
    }

    public Reflect(string type, string desc,  string end) : base(type, end, desc)
    {
        _desc = desc;
       _prompt.Add("Recall a time when you stood up for someone else.");
       _prompt.Add("Recall a time when you accomplished something very challenging.");
       _prompt.Add("Recall a time when you provided assistance to someone in need.");
       _prompt.Add("Recall a time when you performed a truly selfless act.");

       _prompt1.Add("Why was this experience significant to you?");
       _prompt1.Add("Have you ever done something similar before?");
       _prompt1.Add("What motivated you to start?");
       _prompt1.Add("How did you feel after it was over?");
       _prompt1.Add("What made this instance different from other times when you weren't as successful?");
       _prompt1.Add("What is your favorite aspect of this experience?");
       _prompt1.Add("What insights about yourself can you gain from this experience?");
       _prompt1.Add("What did you discover about yourself through this experience?");
       _prompt1.Add("How can you use this experience as a reference in the future?");

    }
    
    public void Ponder()
    {
        Console.WriteLine("Now reflect on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown();
        Console.Clear();
    }
    public void Complete()
    {
        Console.WriteLine($"\nYou have completed {_input} seconds of the {_type} Activity");
    }
    }
    