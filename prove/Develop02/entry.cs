using System.Runtime.CompilerServices;
using System.Transactions;

public class Entry
{
    public string _date;
    public string _entry;
    public string _prompt;

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_entry);
    }
}