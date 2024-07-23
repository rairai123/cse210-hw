public class Lectures : Event
{
    private string _name;
    private int _capacity;

    public Lectures(string name, int capacity, string eventType, string title, string desc, string date, string time) : base(eventType, title, desc, date, time)
    {
        _name = name;
        _capacity = capacity;
    }

    public void lecDesc()
    {
        Console.WriteLine($"Speaker: {_name}, capacity: {_capacity}");
    }
}