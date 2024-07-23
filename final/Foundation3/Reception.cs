public class Reception : Event
{
    private string _email;

    public Reception(string email, string eventType, string title, string desc, string date, string time) : base(eventType, title, desc, date, time)
    {
        _email = email;
    }

    public void recDesc()
    {
        Console.WriteLine($"The person's email who RSVP: {_email}");
    }
}