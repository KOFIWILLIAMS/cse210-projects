class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "When you overcame a challenge.",
        "When you felt truly happy.",
        "A lesson you learned recently."
    };

    private List<string> _questions = new List<string>
    {
        "Was this experience meaningful?",
        "What you learn from it?",
        "Is your life impacted?"
    };

    public ReflectingActivity() : base("Reflection", "Reflect on past experiences and learn from them.") { }

    public override void Run()
    {
        DisplayPrompt();
        DisplayQuestions();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Think about the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("Now consider these questions:");
        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }
    }
}