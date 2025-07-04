using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
          string playAgain;

        do
        {
            // Generate random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Guess My Number Game!");

            // Game loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();

                if (int.TryParse(guessInput, out guess))
                {
                    guessCount++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {guessCount} guesses.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            // Ask to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}