public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        _count = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();

        int randomNum = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomNum];

        Console.WriteLine($"--- {randomPrompt} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>{};
        string response = Console.ReadLine();
        userList.Add(response);

        return userList;
    }
}