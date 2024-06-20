
public class PromptGenerator
{
    List<string> _prompts = new List<string>();
    Random rand = new Random();

    public string getRandomPrompt ()
    {
        _prompts = ["Who was the most important person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the lord in my life today?",
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "When did I have the most fun today?", 
        "How did my day impact the lives of those around me?",
        "What made me laugh today?", 
        "What miracles have I seen in my life today?"];

        int r = rand.Next(_prompts.Count);
        return _prompts[r];
    }
}