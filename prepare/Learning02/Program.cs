using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // System.Console.WriteLine("Hello World!");

        // create a new Job object, job1
        // this will be added to the resume in a sec
        Job job1 = new Job("Software Engineer", "Google", 2013, 2019);

        // create a new Job object, job2
        // this will be added to the resume in a sec
        Job job2 = new Job("Manager", "Apple", 2019, 2020);

        // create a new resume object, named resume1
        var resume1 = new Resume();
        // whose resume is this?
        resume1._name = "Sam Darling";
        // add the two jobs created earlier to the resume
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);

        resume1.Display();
        // GIVE THE RESUME'S OWNER A NAME
    }
}