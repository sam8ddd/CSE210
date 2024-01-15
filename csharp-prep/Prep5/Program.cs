using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("WHat is your favorite integer? ");
            int faveNum = int.Parse(Console.ReadLine());
            return faveNum;
        }

        static long SquareNumber(int faveNum)
        {
            return faveNum*faveNum;
        }

        static void DisplayResult(string name, long faveSquare)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {faveSquare}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int faveNum = PromptUserNumber();
        long faveSquare = SquareNumber(faveNum);
        DisplayResult(name, faveSquare);
    }
}