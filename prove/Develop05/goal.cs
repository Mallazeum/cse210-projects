using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal (string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent ()
    {

    }

    public virtual bool IsComplete ()
    {
        return false;
    }

    public string GetName()
    {
        return _shortName;
    }
    public virtual string GetDetailsString ()
    {
        string display = $"{_shortName}: {_description}  [";
        if (IsComplete())
        {
            display += "X]";
        }
        else
            display += " ]";
        return display;
    }

    public virtual string GetStringRepresentation ()
    {
        string represent = _shortName + "," + _description + "," + _points;
        return represent;
    }

    public virtual int GetPoints()
    {
        return int.Parse(_points);
    }

}