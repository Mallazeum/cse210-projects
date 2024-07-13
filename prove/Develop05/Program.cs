using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();

        gm.Start();
        string input;
        do{
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. See player info");
            Console.WriteLine("2. Record a goal");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Quit");
            input = Console.ReadLine();

            Console.Clear();

            if (input == "1")
            {
                gm.DisplayPlayerInfo();
            }
            else if (input == "2")
            {
                Console.WriteLine("Which goal would you like to record?");
                gm.ListGoalNames();
                input = Console.ReadLine();
                int index = int.Parse(input);
                gm.RecordEvent(gm.GetGoal(index));

            }
            else if (input == "3")
            {
                gm.SaveGoals();
            }
            else if (input == "4")
            {
                gm.CreateGoalString();
            }
            else if (input == "5")
            {
                break;
            }
            else
                Console.WriteLine("Invalid input. Try again");

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }while(true);
    }
}