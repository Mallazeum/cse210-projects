public class OutdoorEvent : Event
{
    private string _forcast;

    public OutdoorEvent (string title, string description, string date, string time, Address address, string forccast) : base(title,description,date,time,address)
    {
        _forcast = forccast;
    }

    public string FullDetails()
    {
        string addressString = _address.DisplayAsString();
        return $"{_title}: {_description} \nType: Outdoor\n{_date}, {_time}\n{addressString}";
    }

    public string ShortDetails()
    {
        return $"Type: Outdoor\n{_title}: {_description}";
    }
}