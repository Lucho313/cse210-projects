using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you did something really difficult.",
        "Think of a time you helped someone in need.",
        "Think of a time you overcame a challenge."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "What did you learn from it?",
        "How did you feel when it was complete?",
        "What made this time different?"
    };

    public ReflectingActivity()
        : base("Reflecting", "This activity helps you reflect on your strengths.")
    {
    }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");

        Console.WriteLine("\nReflect on the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
        }

        End();
    }
}