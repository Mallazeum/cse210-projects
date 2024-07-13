using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private string fileName = "goals.txt";

    public GoalManager ()
    {
        _score = 0;
    }

    public void Start()
    {
        string input;
        Console.WriteLine("How would you like to start?");
        Console.WriteLine("1. Start from scratch");
        Console.WriteLine("2. Load from file");
        input = Console.ReadLine();
        Console.Clear();
        if (input == "1")
        {
            do{
                CreateGoalString();
                Console.Clear();
                Console.WriteLine("Type quit yo finish or hit enter to enter another goal");
                input = Console.ReadLine();
            }while(input != "quit");
        }

        else
            LoadGoals();

        Console.Clear();

    }

    public void DisplayPlayerInfo ()
    {
        Console.WriteLine($"You have {_score} points!");
        ListGoalDetails();

    }

    public void ListGoalNames ()
    {
        for (int i = 0; i < _goals.Count(); i++)
        {
            Goal currentGoal = _goals[i];
            string name = currentGoal.GetName();
            Console.WriteLine($"{i}. {name}");
        }
        
    }

    private void ListGoalDetails ()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    
    private void CreateGoal (string details)
    {
        string[] parts = details.Split(':');
        string type = parts[0];
        string[] info = parts[1].Split(',');
        string name = info[0];
        string description = info[1];
        string points = info[2];
        if (type == "1")
        {
            string isComplete = info[3];
            SimpleGoal newGoal = new SimpleGoal(name,description,points);
            _goals.Add(newGoal);
            if(isComplete == "True")
                RecordEvent(newGoal);
        }
        else if(type == "2")
        {
            int timesCompleted = int.Parse(info[3]);
            EternalGoal newGoal = new EternalGoal(name,description,points);
            _goals.Add(newGoal);
            for (int i= 0; i<timesCompleted;i++)
                RecordEvent(newGoal);
        }
        else if(type == "3")
        {
            int target = int.Parse(info[3]);
            int bonus = int.Parse(info[4]);
            int _amountCompleted = int.Parse(info[5]);

            ChecklistGoal newGoal = new ChecklistGoal(name,description,points,target,bonus);

            for (int i= 0; i<_amountCompleted;i++)
                RecordEvent(newGoal);
            
            _goals.Add(newGoal);
        }
    }

    public void CreateGoalString ()
    {
        Console.WriteLine("What kind of goal would you like to make?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        string input = Console.ReadLine();
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("Give a breif description of your goal.");
        string description = Console.ReadLine();

        Console.WriteLine("How many points is this goal worth?");
        string points = Console.ReadLine();

        string goal = $"{input}:{name},{description},{points}";

        if (input == "1")
        {
            goal += ",false";
            CreateGoal(goal);
        }
        else if(input == "2")
        {
            goal +=",0";
            CreateGoal(goal);
        }
        else if(input == "3")
        {
            Console.WriteLine("How many times would you like to accomplish this goal?");
            string target = Console.ReadLine();
            Console.WriteLine("How many bonus points should you get if you finish all the tasks?");
            string bonus = Console.ReadLine();

            goal += $",{target},{bonus},0";

            CreateGoal(goal);
        }
        else
            Console.WriteLine("Invalid input, Try again");
    }

    public Goal GetGoal(int index)
    {
        return _goals[index];
    }

    public void RecordEvent (Goal goal)
    {
        goal.RecordEvent();
        _score += goal.GetPoints();
    }

    public void SaveGoals ()
    {
        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            foreach(Goal goal in _goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals ()
    {
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            CreateGoal(line);
        }
    }
}