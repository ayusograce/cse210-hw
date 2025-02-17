public abstract class Activity{
    protected string _date;
    protected double _minutes;
    protected string _activity;

    public Activity (string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
        _activity = "Activity";
    }
    
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();


    public virtual string GetSummary(){
        return $" -- {_date} {_activity} ({_minutes} min) - Distance: {GetDistance()}km, Speed: {Math.Round(GetSpeed(), 2)}kph, Pace: {GetPace()} min per km";
    }

}