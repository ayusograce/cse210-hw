using System;
using System.ComponentModel;

//SHOWING CREATIVITY: In the entries, I added a Day Rate for the user to rate his/her day before answering the prompt.

class Program
{
    static void Main(string[] args)
    {
        //Welcome Message
        Console.WriteLine("Welcome to the Journal Program!");

        //Create the journal
        Journal theJournal = new Journal();

        //Menu that needs to iterate until quit
        string response;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            //GENERATE A PROMPT AND WRITE AN ENTRY
            if (response == "1")
            {
                Entry anEntry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                anEntry._date = theCurrentTime.ToShortDateString();

                Console.Write("From 1 to 10 how would you rate this day?: ");
                anEntry._rate = Console.ReadLine();

                PromptGenerator prompt = new PromptGenerator();
                anEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);

                anEntry._entry = Console.ReadLine();

                theJournal.AddEntry(anEntry);
            }

            //DISPLAY ALL THE ENTRIES OF THE DIARY
            if (response == "2")
            {
                theJournal.DisplayAll();
            }

            //LOAD THE DOCUMENT WHERE THE DIARY IS SAVED
            if (response == "3")
            {
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }

            //SAVE THE ENTRIES WRITTEN SO FAR IN THE DOCUMENT
            if (response == "4")
            {
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }


        } while (response != "5");

        //GOODBYE MESSAGE
        Console.WriteLine("Thank you for using the Journal Program. Until next time!");


        
        
    }
}