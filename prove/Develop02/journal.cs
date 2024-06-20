using System.Runtime.CompilerServices;
using System.IO;

public class Journal
{
    List<Entry> journal = new List<Entry>();
    DateTime currentTime = DateTime.Now;
    PromptGenerator prompt = new PromptGenerator();

    public void MakeEntry()
    {
        Entry newEntry = new Entry();
        newEntry._date = currentTime.ToShortDateString();
        string currentPrompt = prompt.getRandomPrompt();
        newEntry._prompt = currentPrompt;
        Console.WriteLine(currentPrompt);
        newEntry._entry = Console.ReadLine();

        journal.Add(newEntry);
    }

    public void ReadAll()
    {
        foreach(Entry item in journal)
        {
            item.Display();
        }
    }

    public void ReadDate ()
    {
        Console.WriteLine("What date would you like to read?");
        string dateToRead = Console.ReadLine();
        int count = 0;
        // By looking through each entry in the Journal I can find and display all of a given date
        foreach(Entry item in journal)
        {
            if (item._date == dateToRead)
            {
                item.Display();
                count += 1;
            }
        }

        // If no entries were found on the given date the counter will not have gone up
        // This makes it possible to display a no entries found message
        if (count == 0)
        {
            Console.WriteLine("No entries found for given date.");
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Where would you like to save Your Journal?(Enter file name with extension)");
        string file = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry item in journal)
            {
                outputFile.WriteLine(item._date);
                outputFile.WriteLine(item._prompt);
                outputFile.WriteLine(item._entry);
            }
        }
    }

    public void LoadFromFile()
    {
        journal.Clear();

        Console.WriteLine("Where would you like to load Your Journal from?(Enter file name with extension)");
        string file = Console.ReadLine();

        string[] parts = System.IO.File.ReadAllLines(file);
        for(int i = 0; i < parts.Length; i += 3)
        {   
            Entry newEntry = new Entry();
            newEntry._date = parts[i];
            newEntry._prompt = parts[i+1];
            newEntry._entry = parts[i+2];
            journal.Add(newEntry);
        }
    }
}