public class Swimming : Activity
{
    private double _numLaps;
    private int _minutes;
    private double _distance;

    public Swimming(string activityType, string date, int minutes, double numLaps) : base(activityType, date, minutes)
    {
        _numLaps = numLaps;
        _minutes = minutes;
    }

    public override double Distance()
    {
        _distance = _numLaps * 50 / 1000;
        return _distance;
    }
    public override double Speed()
    {
        double _speed = _distance / _minutes * 60;
        return _speed;
    }
    public override double Pace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}