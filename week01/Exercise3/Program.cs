using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int number_guess;

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();

            number_guess = int.Parse(guess); 

        if (number_guess > number)
        {
            Console.WriteLine("Lower");
        }
        else if (number_guess < number)
        {
            Console.WriteLine("Higher");
        }

        } while (number_guess != number); 

        Console.WriteLine("You guessed it!");

    }
}