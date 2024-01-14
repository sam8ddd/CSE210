using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,11);

        int guess = 999799;

        do
        {
        System.Console.Write("What is your guess? ");
        string guessStr = System.Console.ReadLine();
        guess = int.Parse(guessStr);

        if (guess == magic)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guess > magic)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            System.Console.WriteLine("Higher");
        }
        } while (guess != magic);
    }
}