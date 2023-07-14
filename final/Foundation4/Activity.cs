class Activity
{
    private DateTime _date;
    private double _activityLength;

    public Activity(string date, double activityLength)
    {
        _date = DateTime.Parse(date);
        _activityLength = activityLength;
    }

    public virtual double GetDistance()
    {
        return (GetSpeed() * GetActivityLength())/60;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / GetActivityLength())*60;
    }

    private double GetPace()
    {
        return 60/GetSpeed();
    }

    private double GetActivityLength()
    {
        return _activityLength;
    }
    
    public string GetSummary(){
        return $"{_date.ToString("dd MMM yyyy")}\t{GetType().Name}  \t({GetActivityLength()} min)\t{GetDistance().ToString("0.00")} miles\t{GetSpeed().ToString("0.00")} mph\t{GetPace().ToString("0.00")} min per mile";
    }
}