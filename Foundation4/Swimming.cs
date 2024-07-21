class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return distance / (lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return lengthInMinutes / distance;
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        return $"{base.GetSummary()} - Distance: {distance:F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}