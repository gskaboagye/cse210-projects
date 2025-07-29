using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new()
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity()
    {
        name = "Reflection Activity";
        description = "This activity will help you reflect on times you've shown strength and resilience.";
    }

    protected override void PerformActivity()
    {
        Random rnd = new();
        Console.WriteLine(prompts[rnd.Next(prompts.Count)]);
        ShowSpinner(4);

        int questionTime = 5;
        int questionCount = duration / questionTime;

        for (int i = 0; i < questionCount; i++)
        {
            string question = questions[rnd.Next(questions.Count)];
            Console.WriteLine("> " + question);
            ShowSpinner(5);
        }
    }
}
