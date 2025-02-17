using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");

        List<Activity> act = new List<Activity>();
        
        Running run = new Running("17 Feb 2025", 30, 4.8);
        Swimming swim = new Swimming("17 Feb 2025", 70, 25);
        Cycling bike = new Cycling("18 Feb 2025", 45, 15);

        
        act.Add(run);
        act.Add(swim);
        act.Add(bike);

        foreach (Activity activity in act)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();
    }
}