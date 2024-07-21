using System.Runtime.CompilerServices;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUS ()
    {
        if(_address.IsUS())
            return true;
        else
            return false;
    }

    public string GetName ()
    {
        return _name;
    }

    public string DisplayAddress ()
    {
        return _address.DisplayAsString();
    }
}