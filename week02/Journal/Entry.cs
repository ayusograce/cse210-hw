public class Entry
{
    public string _date;
    public string _promptText;
    public string _entry;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entry);
        Console.WriteLine();
    }
}