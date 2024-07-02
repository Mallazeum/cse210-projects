public class Assignment
{
    protected string _name;
    private string _topic;

    public Assignment (string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string GetSummary ()
    {
        string summary = _name + ": " + _topic;
        return summary;
    }
}