using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity("24 Jul 2024", 30, 3.75));
        activities.Add(new CyclingActivity("24 Jul 2024", 30, 15));
        activities.Add(new SwimmingActivity("24 jul 2024", 30, 75));

        foreach(Activity item in activities)
        {
            Console.WriteLine(item.Summary());
        }
    }
}