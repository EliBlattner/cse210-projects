using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator Version 1");
        Console.WriteLine("Please enter the grade percentage you recieved:");
        string gradePercentage = Console.ReadLine();
        int gradePercentageNum = int.Parse(gradePercentage);

        if (gradePercentageNum > 70)
        {
            Console.WriteLine($"{int.Parse(gradePercentage)} is your grade percentage. Great job!");
        }
        else if (gradePercentageNum > 50)
        {
            Console.WriteLine("Darn, you didn't pass the class. Better luck next time!");
        }
        else if (gradePercentageNum > 30)
        {
            Console.WriteLine("Yikes, that's not a very good grade...you need some help!");        }
        else if (gradePercentageNum > 15)
        {
            Console.WriteLine("Go talk to academic advising or something!");
        }
        else
        {
            Console.WriteLine("Drop the class before it's too late!");
        }
    }
}