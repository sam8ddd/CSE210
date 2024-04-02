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

    public virtual void Complete(int day)
    {
        isCompleted = true;
    }

    public int getTimeBlock()
    {
        return time;
    }

    public virtual void Display(int day)
    {
        if (isCompleted)
        {
            Console.WriteLine($"[X] {name}: {desc}");
        }
        else
        {
            Console.WriteLine($"[ ] {name}: {desc}");
        }
    }
}