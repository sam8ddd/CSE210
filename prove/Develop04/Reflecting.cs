using System.Diagnostics.CodeAnalysis;

class Reflecting : Activity
{
    List<string> reflectionPrompts = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    List<string> reflectionQuestions = new List<string>(){"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public Reflecting()
    {
        activityDescription = "Welcome to the Reflecting Activity.\n\nThis activity will help you reflect on the times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
        activityName = "Reflecting";
    }

    public void Reflect()
    {
        Random rnd = new Random();
        int rndIdx;
        openMessage();

        System.Console.WriteLine("\nConsider the following prompt:\n");
        rndIdx = rnd.Next(0,reflectionPrompts.Count);
        System.Console.WriteLine(" --- " + reflectionPrompts[rndIdx] + " ---\n");
        System.Console.WriteLine("When you have something in mind, press enter to continue.");
        string dummy = Console.ReadLine();

        System.Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        System.Console.Write("You may begin in: ");
        DoCountdown(5);

        Console.Clear();

        int timeElapsed = 0;
        do
        {
            rndIdx = rnd.Next(0,reflectionQuestions.Count);
            Console.Write("> " + reflectionQuestions[rndIdx] + " ");
            DoSpinner(15);
            Console.Write("\n");

            timeElapsed += 15;
        } while (timeElapsed < timer);

        closeMessage();
    }
}