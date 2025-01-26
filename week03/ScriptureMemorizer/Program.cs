using System;
using System.Runtime.InteropServices;

//To show creativity I added the option to type the verse of scripture that the user wants to memorize.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the ScriptureMemorizer Program.\n");

        Console.WriteLine("Enter 1 to memorize the scripture loaded in the program.");
        Console.WriteLine("Enter 2 to type your own scripture (one verse)");
        string whatToMemorize = Console.ReadLine();

        string book = "";
        int numChapter = 0;
        int numStartVerse = 0;
        int numEndVerse = 0;
        string scripture = "";

        if (whatToMemorize == "1")
        {
            book = "Proverbs";
            numChapter = 3;
            numStartVerse = 5;
            numEndVerse = 6;
            scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }

        else if (whatToMemorize == "2")
        {
            Console.WriteLine("\nPlease enter the scripture that you want to memorize:");
            Console.Write("Book: ");
            book = Console.ReadLine();

            Console.Write("Chapter: ");
            numChapter = int.Parse(Console.ReadLine());

            Console.Write("Verse: ");
            numStartVerse = int.Parse(Console.ReadLine());

            Console.Write("Scripture:");
            scripture = Console.ReadLine();
        }

        else 
        {
            Console.WriteLine("Your answer is not valid. Please reload the program.");
        }

        Reference reference = new Reference(book, numChapter, numStartVerse, numEndVerse);
        Scripture escritura = new Scripture(reference, scripture);

        Console.Clear();
        
        string response;
        do{
           
            Console.WriteLine(escritura.GetDisplayText());

            if (escritura.IsCompletelyHidden())
            {
                break;
            }
            escritura.HideRandomWords(3);

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            Console.Clear();
        } while (response != "quit");        
    }
}