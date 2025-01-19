public class PromptGenerator
{
    public List<string> _prompts = new List<string>{
        "What are you grateful for today?",
        "What is something interesting that happened today?",
        "How did you see the hand of the Lord in your life today?",
        "What happened today that made you happy?",
        "Who did you meet today that caused a great impact in you?"
    };



    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomNum = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomNum];
        return randomPrompt;
    }

}