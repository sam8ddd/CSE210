using System.Security.Cryptography.X509Certificates;

public class Resume
    {
        //Responsibilities: Keeps track of the person's name and a list of their jobs.

        public string _name = "";
        public List<Job> _jobList = new List<Job>();

        public void Display()
        {
            System.Console.WriteLine($"Name: {_name}");
            System.Console.WriteLine("Jobs: ");
            foreach (Job i in _jobList)
            {
                i.Display();
            }
        }
    }