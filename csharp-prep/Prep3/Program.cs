using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        //Console.WriteLine("What is your magic number?");
        //string magicNumber = Console.ReadLine();
        //int magicNumberNum = int.Parse(magicNumber);

        bool guess = false;

        while (guess == false)
        {
            Console.WriteLine("What is your guess?");
            string userGuess = Console.ReadLine();
            int userGuessNum = int.Parse(userGuess);
            if (number > userGuessNum)
            {
                Console.WriteLine("Higher");
            }
            else if (number < userGuessNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Nice job! You guessed it!");
                guess = true;
            }
        }
    }
}