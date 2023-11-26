using System;

class Program
{
    static void Main(string[] args)
    {

        string _userMenuChoice = "99";

        Console.WriteLine("Welcome to the Wellness Program!\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Quit");

        while (_userMenuChoice != "4")
        {
            Console.WriteLine("Enter Menu Choice. Type '4' to exit the program: ");
            _userMenuChoice = Console.ReadLine();
        }
    }
}