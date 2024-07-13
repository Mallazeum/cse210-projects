public class SimpleGoal : Goal
{
    private bool _iscomplete;
    public SimpleGoal (string name, string description, string points) : base(name,description,points)
    {
        _iscomplete = false;
    }

    public override void RecordEvent()
    {
        _iscomplete = true;
    }

    public override bool IsComplete()
    {
        if (_iscomplete)
            return true;
        else
            return false;
    }

    public override string GetStringRepresentation()
    {
        string represent = $"1:{_shortName},{_description},{_points},{_iscomplete}";
        return represent; 
    }
}