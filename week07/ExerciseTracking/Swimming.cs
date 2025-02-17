public class Swimming : Activity{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
        _activity = "Swimming";
    }

    public override double GetDistance()
    {
        return _laps * 0.05;
    }

    public override double GetSpeed()
    {
        double distance = _laps * 0.05;
        double speed = 60 * distance / _minutes;
        return speed;
    }

    public override double GetPace()
    {
        return _minutes / (_laps * 0.05) ;
    }
}