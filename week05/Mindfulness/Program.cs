using System;
using System.ComponentModel.Design;
using System.Reflection;

class Program
{
    // SHOWING CREATIVITY: The program keeps a record of how many activities were performed in total and in each activity.
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string number = "";

        int numActTotal = 0;
        int numBreathing = 0;
        int numReflecting = 0;
        int numListing = 0;

        do{
            Console.Clear();
            Console.WriteLine($"\nNumber of activities performed: {numActTotal} (Breathing: {numBreathing}, Reflecting: {numReflecting}, Listing: {numListing})\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            number = Console.ReadLine();

            if (number == "1")
            {
                // BREATHING ACTIVITY
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                numBreathing++;
            }

            else if(number == "2")
            {
                //REFLECTING ACTIVITY
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                numReflecting++;
            }

            else if(number == "3")
            {
                //LISTING ACTIVITY
                ListingActivity listing = new ListingActivity();
                listing.Run();
                numListing++;
            }
            numActTotal = numBreathing + numListing + numReflecting;
            
        }while(number != "4");
    }
}