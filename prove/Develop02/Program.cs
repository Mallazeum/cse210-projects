using System;

class Program
{
    
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        while (true)
        {   
            Console.WriteLine("Welcome to your Journal! What would you like to do?");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Read entire journal");
            Console.WriteLine("3. Read entries by date");
            Console.WriteLine("4. Save Journal to File");
            Console.WriteLine("5. Load Journal from File ");
            Console.WriteLine("6. Quit");
            string input = Console.ReadLine();
            if (input == "1")
            {
                currentJournal.MakeEntry();
            }
            else if (input == "2")
            {
                currentJournal.ReadAll();
            }
            else if (input == "3")
            {
                // I added this function, it allows the user to read 
                // All the journal entries on a given date that they enter.
                currentJournal.ReadDate();
            }
            else if (input == "4")
            {
                currentJournal.SaveToFile();
            }
            else if (input == "5")
            {
                currentJournal.LoadFromFile();
            }
            else if (input == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input try again");
            }
        }
    }
}