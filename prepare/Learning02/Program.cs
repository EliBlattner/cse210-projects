using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        
        job1._company = "Walmart";
        job1._jobName = "Cashier";
        job1._startYear = "2005";
        job1._endYear = "2007";

        Job job2 = new Job();

        job2._company = "FedEx";
        job2._jobName = "Delivery Driver";
        job2._startYear = "2007";
        job2._endYear = "2009";

        Resume resume1 = new Resume();
        resume1._name = "Eli Blattner";

        resume1._jobsList.Add(job1);
        resume1._jobsList.Add(job2);

        resume1.Display();
        

    }
}