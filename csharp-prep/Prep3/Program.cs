using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicStr = System.Console.ReadLine();
        int magic = int.Parse(magicStr);

        System.Console.Write("What is your guess? ");
        string guessStr = System.Console.ReadLine();
        int guess = int.Parse(guessStr);

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
    }
}