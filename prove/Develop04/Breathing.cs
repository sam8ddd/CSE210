class Breathing : Activity
{
    public Breathing()
    {
        activityDescription = "Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on breathing.\n";
        activityName = "Breathing";
    }

    public void Breathe()
    {
        openMessage();

        int timeElapsed = 0;
        do
        {
            Console.Write("\nBreathe in...");
            DoCountdown(4);
            Console.Write("\nNow Breathe out...");
            DoCountdown(6);
            System.Console.Write("\n");

            timeElapsed += 10;
        } while (timeElapsed < timer);

        closeMessage();
    }
}