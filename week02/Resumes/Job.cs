  using System;
  namespace FirstClass
  {
  // class job
        public class Job{
            public string _company = "company" ;
            public string _jobTitle = "job title";	
            public int _startYear = 0;
            public int _endYear = 0;

            //adding a constructor
            
            public void Display(){
                Console.WriteLine($"{_jobTitle} at ({_company}) from {_startYear} to {_endYear}");
            }
        }
}