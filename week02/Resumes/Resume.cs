using System;
namespace FirstClass
{
//class resume
public class Resume{
            public string _name;
            public List<Job> _jobs;

             public Resume(string name)
    {
        _name = name;  // initialize the name
        // Initialize the list of jobs
        _jobs = new List<Job>();
    }
             public void Display()
        {
            Console.WriteLine($"{_name} has worked at:");

            if (_jobs.Count == 0)
            {
                Console.WriteLine("No jobs to display.");
            }
            else
            {
               // job details
                foreach (var job in _jobs)
                {
                    job.Display(); 
                }
            }

        }
}
}