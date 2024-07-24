public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity (string date, int length, int laps) : base(date,length)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        distance = Math.Round(distance,1);
        return distance;
    }

    public override string Type()
    {
        return "Swimming";
    }
}