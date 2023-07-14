class Running : Activity
{
    private double _distance;

    public Running(double distance, string date, double activityLength) : base(date, activityLength)
    {
        _distance = distance;
    }

     public override double GetDistance()
    {
        return _distance;
    }
}