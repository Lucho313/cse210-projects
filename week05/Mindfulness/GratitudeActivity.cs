using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "What are you grateful for today?",
        "Who made your day better?",
        "What simple thing made you smile?"
    };

    public GratitudeActivity()
        : base("Gratitude", "Focus on gratitude and positivity.")
    {
    }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");

        Console.WriteLine("\nReflect...");
        ShowSpinner(_duration);

        End();
    }
}