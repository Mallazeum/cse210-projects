using System.ComponentModel;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected Random r = new Random();
    public DateTime startTime;

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage ()
    {
        string display = "Welcome to " + _name + " activity. " + _description;
        Console.WriteLine(display);
        Console.WriteLine("How long would you like to do this activity?(In Seconds)");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin.");
        ShowCountDown(3);
        startTime = DateTime.Now;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("You have finished, Great job.");
        DateTime endTime = DateTime.Now;
        ShowSpinner(3);
        TimeSpan timeSpent = endTime - startTime;
        Console.WriteLine("You spent " + timeSpent.TotalSeconds + " seconds on " + _name + " activty.");
    }

    public void ShowSpinner (int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("^");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("›");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("v");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("‹");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

    }

    public void ShowCountDown (int seconds)
    {
        for (int i = seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}