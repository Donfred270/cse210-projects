using System;
using System.Security.Cryptography.X509Certificates;
using FirstClass;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Corp";
        job1._startYear = 2020;
        job1._endYear = 2022;
        job1.Display();

        // Create another job object
        Job job2 = new Job();
        job2._jobTitle = "Graphic designer";
        job2._company = "H-translation and consulting";
        job2._startYear = 2020;
        job2._endYear = 2022;
        job2.Display();


        // create a new resume object
        Resume myResume = new Resume("Donfred Vallon");
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
        
    }
}