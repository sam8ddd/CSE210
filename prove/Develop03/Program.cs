using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string input = "";
        bool doQuit = false;

        do
        {
            // there are 2 quit conditions: if the text is all blank (then quit after showing the fully blank scripture)
            // ~OR~ the user types quit (then exit the program immediately)
            if (scripture.IsAllBlank())
            {
                doQuit = true;
            }

            Console.Clear();
            scripture.DisplayScripture();
            System.Console.WriteLine("");

            System.Console.WriteLine("Press enter to continue or type \'quit\' to finish:");
            input = System.Console.ReadLine();
            
            if (input == "quit")
            {
                doQuit = true;
            }
        } while (!doQuit);
    }
}