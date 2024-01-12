using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        /* to comment out
        multiple
        lines */

        // how to declare a variable
        int num1 = 34;
        int num2 = 3;
        string myName = "Sam";

        // OR use var to have C# automatically assign the variable type
        var num3 = 5;
        var mySurname = "Darling";

        // to print out your variables to the console
        Console.Write("A Name: ");
        Console.WriteLine("Bob");   // WriteLine is like Write, but it adds a newline afterward
        // OR use Console.WriteLine($"A Name: {myName}"); or ("A Name: " + myName);

        // to read in a line from user
        System.Console.WriteLine("What's your name?");   //use cw + TAB as a shortcut
        var userName = Console.ReadLine();

        // converting variables
        System.Console.WriteLine("What's your age?");   //use cw + TAB as a shortcut
        var ageString = Console.ReadLine();
        var age = int.Parse(ageString);

        //conditionals
        if (age < 18)
        {
            System.Console.WriteLine("You are a minor.");
            System.Console.WriteLine("...nerd");
        }
        else
            System.Console.WriteLine("You are not a minor.");
    }
}