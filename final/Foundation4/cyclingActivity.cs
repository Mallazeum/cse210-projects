public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date,int length, int speed) : base(date,length)
    {
        _speed = speed;
    }

    public override string Type()
    {
        return "Cycling";
    }

    public override double Distance()
    {
        double distance = (_speed / 60) * _activityLength;
        return distance;
    }

    public override double Speed()
    {
        double speed = Math.Round(_speed,1);
        return speed;
    }
}