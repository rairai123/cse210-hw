public class Activity
{
    public int _input = 0;
    protected string _type;
    protected string _end;
    protected string _length;
    protected string _desc;
    List<string> animation = new List<string>();

    public Activity(string type, string end, string desc)
    {
        _type = type;
        _end = end;
        _desc = desc;

        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
    }
    public void Animation()
    {
        foreach (string anime in animation)
        {
            Console.Write(anime);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public string WelcomeDisplay()
    {
        return $"Welcome to the {_type} Activity.\n";
    }

    public string Description()
    {
        return _desc;
    }

    public string endMessage()
    {
        return _end;
    }
    public void Countdown()
    {
        for (int i = 8; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready");

    }
    public void Question()
    {
        Console.WriteLine("How long, in seconds, would you like your activity session? ");
        _input = Convert.ToInt32(Console.ReadLine());
    }
}