using System.Net.Sockets;

class Task
{
    protected string name;
    protected string desc;
    protected int time;
    protected bool isCompleted;

    public Task(int timeBlock)
    {
        time = timeBlock;

        Console.Write("Task Name: ");
        name = Console.ReadLine();

        Console.Write("Task Description: ");
        desc = Console.ReadLine();

        isCompleted = false;
    }

    public void Complete()
    {
        isCompleted = true;
    }

    public virtual void Display()
    {
        if (isCompleted) {Console.WriteLine($"[X] {name}: {desc}");}
        else{Console.WriteLine($"[ ] {name}: {desc}");}
    }

    public bool DisplayIfOccupied(int slot)
    {
        if (slot == time)
        {
            Display();
            return true;
        }
        else
        {
            return false;
        }
    }
}