using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("What grade (%) did you get?: ");
        string gradeNumString = Console.ReadLine();
        int gradeNum = int.Parse(gradeNumString);

        if (gradeNum >= 90)
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (gradeNum >= 80)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (gradeNum >= 70)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (gradeNum >= 60)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is F.");
        }

        if (gradeNum >= 70)
        {
            System.Console.WriteLine("You passed the class! Congrats!");
        }
        else
        {
            System.Console.WriteLine("You did not pass the class. But there's always next time!");
        }
    }
}