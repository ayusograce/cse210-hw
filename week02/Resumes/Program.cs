using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2014;
        job1._endYear = 2016;


        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Web developer";
        job2._startYear = 2017;
        job2._endYear = 2022;


        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.DisplayResume();
    }
}