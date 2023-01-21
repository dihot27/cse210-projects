using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
       Job job1=new Job();
        job1._jobTitle="Owner";
        job1._companyName="DihoT Sandwiches";
        job1._startYear="2018";
        job1._endYear="2020";
        job1.Display();
        
        Job job2=new Job();
         job2._jobTitle="Technician" ;
         job2._companyName="Top it up" ;
         job2._startYear="2021";
         job2._endYear="Current";
         job2.Display();

         Resume myResume=new Resume();
         myResume._jobs.Add(job1);
         myResume._jobs.Add(job2);

         myResume.Display();


      
    
        
    }
}