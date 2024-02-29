using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice;

        do
        {
            Console.Clear();

            System.Console.WriteLine("Menu Options");
            System.Console.WriteLine("  1. Start breathing activity");
            System.Console.WriteLine("  2. Start reflecting activity");
            System.Console.WriteLine("  3. Start listing activity");
            System.Console.WriteLine("  4. Quit");
            System.Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing myActivity = new Breathing();
                myActivity.Breathe();
            }
            else if (choice == "2")
            {
                Reflecting myActivity = new Reflecting();
                myActivity.Reflect();
            }
            else if (choice == "3")
            {
                Listing myActivity = new Listing();
                myActivity.List();
            }

        } while(choice != "4" );
    }
}