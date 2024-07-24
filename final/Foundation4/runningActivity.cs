public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity (string date,int length, double distance) : base(date,length)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override string Type()
    {
        return "Running";
    }
}