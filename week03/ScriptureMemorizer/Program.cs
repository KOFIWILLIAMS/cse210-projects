using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Acts", 3, 9), "And all the people saw him walking and praising God"),
            new Scripture(new Reference("John", 11, 35), "Jesus Wept"),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart and lean not on your own understanding."),
            new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heavens and the earth."),
            new Scripture(new Reference("1 Peter", 5, 7), "Leave all your burden with him, because He cares for you")
        };

        var random = new Random();
        var selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            selectedScripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine("All words are hidden. Program has ended.");
    }
}