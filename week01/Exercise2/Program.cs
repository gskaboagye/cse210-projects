using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
         // Ask for the user's percentage grade
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";
        bool passed = false;

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
            passed = true;
        }
        else if (grade >= 80)
        {
            letter = "B";
            passed = true;
        }
        else if (grade >= 70)
        {
            letter = "C";
            passed = true;
        }
        else if (grade >= 60)
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
        }

        // Determine the sign
        int lastDigit = grade % 10;
        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade < 93) // A- applies from 90–92
        {
            sign = "-";
        }

        // Print the result
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Message based on pass/fail
        if (passed)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard and you'll get it next time.");
        }
    }
}