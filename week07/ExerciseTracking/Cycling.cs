public class Cycling : Activity{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
        _activity = "Cycling";
    }

    public override double GetDistance()
    {
        return _speed * _minutes / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}