using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program.");
        }

        static string PromptUserName()
        {
            Console.Write("Please, enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please, enter your favorite number: ");
            int favorite_number = int.Parse(Console.ReadLine());

            return favorite_number;
        }

        static int SquareNumber(int favorite_number)
        {
            int square = favorite_number * favorite_number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {square}");
        }

    }
}