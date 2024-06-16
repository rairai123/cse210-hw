public class Breathing : Activity
{   
    public Breathing(string type, string desc, string end) : base(type, end, desc)
    {
        _input = 0;
    }   
    public void BreathingIn()
    {
        Console.Write("\nBreath in......hold it.....");
        Countdown();
        Console.Write("\nAnd breath out......relax.....");
        Countdown();
    }


    public void Exercise()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_input);
        while (DateTime.Now < endTime)
        {
            BreathingIn();
        }
    }
    
}