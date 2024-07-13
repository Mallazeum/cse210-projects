using System.Drawing;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal (string name, string description, string points, int target, int bonus) : base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
            return true;
        else
            return false;
    }

    public override string GetDetailsString()
    {
        string display = $"{_shortName}: {_description} [{_amountCompleted}/{_target}]";
        return display;
    }

    public override string GetStringRepresentation()
    {
        string represent = $"3:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
        return represent;
    }

    public override int GetPoints()
    {

        if(_amountCompleted == _target)
            return int.Parse(_points) + _bonus;

        else
            return int.Parse(_points);
    }

}