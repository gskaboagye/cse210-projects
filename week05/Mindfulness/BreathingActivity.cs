using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by guiding you through deep breathing.";
    }

    protected override void PerformActivity()
    {
        int cycleTime = 6;
        int totalCycles = duration / cycleTime;

        for (int i = 0; i < totalCycles; i++)
        {
            Console.Write("Breathe in...");
            Countdown(3);
            Console.Write("Now breathe out...");
            Countdown(3);
        }
    }
}
