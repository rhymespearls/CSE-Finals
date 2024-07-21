class StationaryBicycles : Activity
{
    private double speed;

    public StationaryBicycles(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
