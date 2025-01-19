using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>{};

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entrada in _entries)
        {
            entrada.Display();
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(file))
        {           
            foreach (Entry entrada in _entries)
            {
                outputFile.WriteLine($"Date: {entrada._date} - Day Rate :{entrada._rate} - Prompt: {entrada._promptText}");
                outputFile.WriteLine(entrada._entry);
                outputFile.WriteLine();
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}