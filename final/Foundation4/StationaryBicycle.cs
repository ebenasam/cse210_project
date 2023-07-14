class StationaryBicycle : Activity
{
    private double _speed;
    
    public StationaryBicycle(double speed, string date, double activityLength) : base(date, activityLength)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}