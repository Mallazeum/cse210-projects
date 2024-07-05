using System;

class Program
{
    // Added a counter for each activity and tell them how much time 
    // they spent being mindful.
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity();
        ListingActivity listing = new ListingActivity();
        ReflectingActivity reflect = new ReflectingActivity();
        DateTime startTime = DateTime.Now;
        int breathCount = 0;
        int listCount = 0;
        int reflectCount = 0;

        Console.WriteLine("Welcome to our mindfulness program!");
        string input;
        do{
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Which activity would you like to do");
            input = Console.ReadLine();
            Console.Clear();

            if (input == "1")
            {
                breath.Run();
                breathCount++;
            }
            else if (input == "2")
            {
                reflect.Run();
                reflectCount++;
            }
            else if (input == "3")
            {
                listing.Run();
                listCount++;
            }
            else if (input == "4")
                break;
            else
                Console.WriteLine("Invalid input");

            breath.ShowSpinner(5);
            Console.Clear();
        }while(true);

        TimeSpan timeSpent = DateTime.Now - startTime;
        Console.WriteLine($"Congradulations! You have spent {timeSpent.TotalSeconds} seconds being mindful!");
        if (breathCount > 0)
            Console.WriteLine($"You completed the breathing activity {breathCount} times.");
        if (reflectCount > 0)
            Console.WriteLine($"You completed the reflecting activity {reflectCount} times.");
        if (listCount > 0)
            Console.WriteLine($"You completed the listing activity {listCount} times.");
    }
}