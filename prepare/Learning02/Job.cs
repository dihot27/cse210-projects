using System;

public class Job
{
    public string _companyName;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle}({_companyName}){_startYear}-{_endYear}");
    }

    
}