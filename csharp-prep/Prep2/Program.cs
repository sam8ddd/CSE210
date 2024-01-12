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

        string letter;
        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        System.Console.WriteLine($"Your letter grade is {letter}");

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