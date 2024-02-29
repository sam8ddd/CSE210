class Listing : Activity
{
    List<string> listingPrompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public Listing()
    {
        activityDescription = "Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";
        activityName = "Listing";
    }

    public void List()
    {
        Random rnd = new Random();
        int rndIdx;
        openMessage();

        System.Console.WriteLine("\nList as many responses you can to the following prompt:");
        rndIdx = rnd.Next(0,listingPrompts.Count);
        System.Console.WriteLine(" --- " + listingPrompts[rndIdx] + " ---");
        System.Console.Write("You may begin in: ");
        DoCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(timer);
        int responses = 0;
        Console.Write("\n");
        do
        {
            Console.Write("> ");
            string dummy = Console.ReadLine();
            responses += 1;
        } while (DateTime.Now < endTime);

        Console.WriteLine("You listed " + responses + " items!");

        closeMessage();
    }
}