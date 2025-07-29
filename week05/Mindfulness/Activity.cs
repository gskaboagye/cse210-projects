using System;
using System.Threading;

public class Activity
{
    protected int duration;
    protected string name;
    protected string description;

    public void Run()
    {
        DisplayStartMessage();
        PerformActivity();
        DisplayEndMessage();
    }

    protected virtual void PerformActivity()
    {
        // To be overridden
    }

    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting: {name}");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("\nGreat job!");
        ShowSpinner(2);
        Console.WriteLine($"You completed the {name} for {duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
