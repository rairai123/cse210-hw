public abstract class Activity
{
    private string _date;
    private string _activityType;
    private int _minutes;

    public Activity(string activityType, string date, int minutes)
    {
        _activityType = activityType;
        _date = date;
        _minutes = minutes;
    }
    
    public abstract double Distance();

    public abstract double Speed();
    public abstract double Pace();
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_minutes} min) - Distance:{Distance()} miles, Speed:{Speed()} mph, Pace: {Pace()} min per mile");
    }
}