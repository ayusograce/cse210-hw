using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int favoriteNumber = int.Parse(number);
        return favoriteNumber;
    }

    static int SquareNumber(int favoriteNumber)
    {
        //Obtain the square of the favoriteNumber
        int square = favoriteNumber * favoriteNumber;
        return square;
    }

    static void DisplayResult (string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}