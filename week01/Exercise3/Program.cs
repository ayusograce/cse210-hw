using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        /* To ask the user for the random number
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);
        */

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine("Ready to play? Guess the number!");

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);
        
    }
}