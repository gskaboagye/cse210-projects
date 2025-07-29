using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "This activity helps you reflect by listing as many positive things as you can.";
    }

    protected override void PerformActivity()
    {
        Random rnd = new();
        Console.WriteLine(prompts[rnd.Next(prompts.Count)]);
        Console.WriteLine("Start listing items:");
        Countdown(3);

        List<string> responses = new();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
                responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items.");
    }
}
