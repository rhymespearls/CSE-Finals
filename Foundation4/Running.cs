class Running : Activity
{
    private double distance;

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return lengthInMinutes / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {distance:F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}