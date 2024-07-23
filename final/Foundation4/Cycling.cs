public class Cycling : Activity
{
    private double _speed;
    private double _minutes;

    public Cycling(string activityType, string date, int minutes, double speed) : base(activityType, date, minutes)
    {
        _speed = speed;
        _minutes = minutes;
    }


    public override double Speed()
    {
        return _speed;
    }
    public override double Distance()
    {
        double _distance = _minutes/60*_speed;
        return Math.Round(_distance,2);
    }
    public override double Pace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}