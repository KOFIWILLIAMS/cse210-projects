using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Helloo! Please Welcome to 'Eternal Quest Program' !");
        Console.WriteLine("Track your goals and level up each day");
        Console.WriteLine("***************************");

        GoalManager manager = new GoalManager();
        manager.Start();

        Console.WriteLine("Goodbye, see you next time");
    }
}