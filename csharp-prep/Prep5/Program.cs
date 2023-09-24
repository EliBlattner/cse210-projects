using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {userName}!");
            return userName;
        }

        static void PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string favNumb = Console.ReadLine();
            int favNumbInt = int.Parse(favNumb);
            Console.WriteLine($"Your favorite number is {favNumbInt}!");
        }
        
        DisplayWelcome();

        PromptUserName();

        PromptUserNumber();

        Console.WriteLine("What is a number you'd like to multiply by itself?");
        string numbSquared = Console.ReadLine();
        int numbSquaredInt = int.Parse(numbSquared);

        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }
        
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Your name is {name} and your number squared is {number}!");
        }

        SquareNumber(numbSquaredInt);

        string nameInput = PromptUserName();
        //Still can't manage to get this working. It should be returning the userName, but instead it is running the entire function at that location.

        DisplayResult(nameInput, SquareNumber(numbSquaredInt));

    }  
}