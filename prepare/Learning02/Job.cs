using System;

public class Job
{

    public string _company;
    public string _jobName;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobName} ({_company}) | {_startYear} - {_endYear}");
        
    }

}