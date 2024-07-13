public class EternalGoal : Goal
{
    int _timesCompleted;
    public EternalGoal (string name, string description, string points) : base(name,description,points)
    {

    }

    public override void RecordEvent()
    {
        _timesCompleted++;
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetDetailsString()
    {
        string display = $"{_shortName}: {_description}  [";
        display += _timesCompleted;
        display+= ']';
        return display;
    }

    public override string GetStringRepresentation()
    {
        string represent = $"2:{_shortName},{_description},{_points},{_timesCompleted}";
        return represent;
    }
}