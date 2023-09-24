using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int userArgument = 1;
        Console.WriteLine("Please enter numbers one at a time to be appended to a list. Enter 0 when finished.");
        List<int> numbers = new List<int>();

        while (userArgument != 0)
        {
            Console.WriteLine("Enter a number: ");
            string newNumber = Console.ReadLine();
            int newNumberInt = int.Parse(newNumber);
            numbers.Add(newNumberInt);
            userArgument = newNumberInt;
        }
        int largestNumber = 0;
        int sumTotal = 0;
        foreach (int number in numbers)
        {
            sumTotal += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        int listCount = numbers.Count;
        int finalAverage = sumTotal / listCount;
        Console.WriteLine($"{sumTotal} is the sum of your numbers.");
        Console.WriteLine($"The average is {finalAverage}");
        Console.WriteLine($"The largest number in the list is {largestNumber}.");

    }   

}