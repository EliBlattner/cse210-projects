using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello! what is your first name? ");
        string first = Console.ReadLine();

        Console.Write("And what is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"That would make you {last}, {first} {last}.");
    }
}