using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();

        int number_number;
        do
        {
            Console.Write("Enter Number ");
            string number = Console.ReadLine();
            number_number = int.Parse(number);

            numbers.Add(number_number);

        } while (number_number != 0);

        int sum;
        sum = numbers.Sum();
        double avg;
        avg = numbers.Average();
        int max;
        max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}"); 
        Console.WriteLine($"The largest number is: {max}");

    }
}