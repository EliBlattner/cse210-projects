using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator Version 1");
        Console.WriteLine("Please enter the grade percentage you recieved:");
        string gradePercentage = Console.ReadLine();
        Console.WriteLine($"{int.Parse(gradePercentage)} is your grade percentage.");
        
    }
}