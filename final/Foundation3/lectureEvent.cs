public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title,description,date,time,address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        string addressString = _address.DisplayAsString();
        return $"{_title}: {_description} \nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}\n{_date}, {_time}\n{addressString}";
    }

    public string ShortDetails()
    {
        return $"Type: Lecture\n{_title}: {_description}";
    }
}