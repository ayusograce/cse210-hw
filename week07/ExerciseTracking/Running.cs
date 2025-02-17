public class Running : Activity{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
        _activity = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return 60 * _distance / _minutes;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }
}