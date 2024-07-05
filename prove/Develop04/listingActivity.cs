public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?",
    "What are personal strengths of yours?", "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity(string name = "listing", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(name,description)
    {

    }

    public void Run ()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    private void GetRandomPrompt ()
    {
        int rand = r.Next(0,_prompts.Count());
        Console.WriteLine(_prompts[rand]);
        ShowCountDown(5);
    }

    private void GetListFromUser()
    {
        startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;
        Console.WriteLine("List all your items.(Press enter after each one)");
        do{
            Console.ReadLine();
            _count++;
            currentTime = DateTime.Now;
        }while(currentTime < futureTime);
        Console.WriteLine($"You listed {_count} items.");
    }
}