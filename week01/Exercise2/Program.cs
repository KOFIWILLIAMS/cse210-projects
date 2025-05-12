using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();

        int number_grade = int.Parse(grade);

        string letter;

        if (number_grade>=90)
        {
            letter = "A";
        }
        else if (number_grade>=80)
        {
            letter = "B";
        }
        else if (number_grade>=70)
        {
            letter = "C"; 
        }
        else if (number_grade>=60)
        {
            letter = "D"; 
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (number_grade>=70)
        {
            Console.WriteLine("Congratulations, you have passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you haven't passed. There's always a second chance, though!");
        }
    }
}