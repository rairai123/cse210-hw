public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string weather, string eventType, string title, string desc, string date, string time) : base(eventType, title, desc, date, time)
    {
        _weather = weather;
    }

    public void outDesc()
    {
        Console.WriteLine($"The weather for today will be {_weather}");
    }
}