public class Event
{
    private string _eventType;
    private string _title;
    private string _desc;
    private string _date;
    private string _time;

    public Event(string eventType, string title, string desc, string date, string time)
    {
        _eventType = eventType;
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
    }

    public void Type()
    {
        Console.WriteLine($"{_eventType} event.\n");
    }

    public void shortDesc()
    {
        Console.WriteLine($"{_eventType} event, {_title}, {_date}");
    }

    public void standardDesc()
    {
        Console.WriteLine($"{_title}, {_desc}, {_date}, {_time}");
    }

    
}