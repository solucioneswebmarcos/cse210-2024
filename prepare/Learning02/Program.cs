using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Engineer";
        job1._starYear = 2001;
        job1._endYear = 2003;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._starYear = 2004;
        job2._endYear = 2014;

        Resume resume = new Resume();
        resume._name = "Marcos Arias";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}