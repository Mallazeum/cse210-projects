public class BreathingActivity : Activity
{
    public BreathingActivity (string name = "breathing", string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime;
        do{
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            currentTime = DateTime.Now;
            if (currentTime >= futureTime)
            {
                break;
            }
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
            currentTime = DateTime.Now;
        }while(currentTime < futureTime);
        DisplayEndingMessage();
    }
}