using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Maximum
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Stretch: Smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch: Sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}