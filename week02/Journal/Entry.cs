public class Entry
{
    public string _date;
    public string _promptText;
    public string _entry;
    public string _rate;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Day Rate :{_rate} - Prompt: {_promptText}");
        Console.WriteLine(_entry);
        Console.WriteLine();
    }
}