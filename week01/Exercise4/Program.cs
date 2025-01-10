using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> listOfNumbers = new List<int>();

        int number;
        int sum = 0;
        int largest = -1;

        do
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            listOfNumbers.Add(number);

            sum = sum + number;

            if (number > largest)
            {
                largest = number;
            }

        } while (number != 0);

        int listLenght = listOfNumbers.Count - 1;
        float lenght = (float)listLenght;
        float total = (float)sum;

        float average = total / lenght;


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}