public class ReceptionEvent : Event
{
    public ReceptionEvent (string title, string description, string date, string time, Address address) : base(title,description,date,time,address)
    {

    }

    public string FullDetails()
    {
        string addressString = _address.DisplayAsString();
        return $"{_title}: {_description} \nType: Reception\n{_date}, {_time}\n{addressString}";
    }

    public string ShortDetails()
    {
        return $"Type: Reception\n{_title}: {_description}";
    }
}