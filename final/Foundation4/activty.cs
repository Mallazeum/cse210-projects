using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

public class Activity
{
    protected string _date;
    protected int _activityLength;

    public Activity (string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public virtual double Distance ()
    {
        double distance = 0;
        return distance;
    }

    public virtual double Speed ()
    {
        double speed = 60 / Pace();
        speed = Math.Round(speed,1);
        return speed;
    }

    public virtual string Type ()
    {
        return "";
    }

    public double Pace ()
    {
        double distance = Distance();
        double pace = _activityLength / distance;
        pace = Math.Round(pace,2);

        return pace;
    }

    public string Summary ()
    {
        double distance = Distance();
        double speed = Speed();
        double pace = Pace();
        string type = Type();

        string summary = $"{_date} {type} ({_activityLength} min)- Distance {distance} miles, Speed {speed} mph, Pace {pace} min per mile";
        return summary;
    }
}