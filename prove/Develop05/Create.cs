public class Create
{  
    public string _name;
    public string _desc;
    public int _points;
    public Create(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }
    public void Questions()
    {
        Console.WriteLine("Please name your goal. ");
        _name = Console.ReadLine() ?? String.Empty;
        Console.WriteLine("Give a short description of your goal. ");
        _desc = Console.ReadLine() ?? String.Empty;
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
    }

}