public class Listing : Activity
{
    string quest = "";
    List<string> question = new List<string>();
    List<string> answers = new List<string>();
    public Listing(string type, string desc, string end) : base(type, desc, end)
    {
        question.Add("Who are the people you appreciate the most in your life?");
        question.Add("What are some of your personal strengths and talents?");
        question.Add("Who are the people you have supported or helped this week?");
        question.Add("When have you felt a deep sense of peace or inspiration recently?");
        question.Add("Who are some of your personal heroes and why do you admire them?");
        question.Add("What are the things that bring you the most joy?");
        question.Add("How do you handle challenges and setbacks in your life?");
        question.Add("What are some goals you have set for yourself this year?");
        question.Add("How do you practice gratitude in your daily life?");
        question.Add("What is a recent accomplishment you are proud of and why?");
    }
    

    public void RandomPrompt()
    {
        Random random = new Random();
        int num = random.Next(0,question.Count);
        quest = question[num];
        Console.WriteLine("List as many responses you can:");
        Console.WriteLine($"--- {quest} ---");
        Console.WriteLine("You may begin answering in: ");
    }


    public void Begin()
    {
        string amount;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_input);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("> ");
            amount = Console.ReadLine();
            answers.Add(amount);
        }
        Console.WriteLine($"You listed {answers.Count} responses!");
    }
}