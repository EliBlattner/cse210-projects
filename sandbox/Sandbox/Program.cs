using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        string userMenuChoice = "99";

        Transfer transfer1 = new Transfer();
        Deposit deposit1 = new Deposit(); 
        Withdraw withdraw1 = new Withdraw();
        Invest invest1 = new Invest();
        ATMAnimations atmAnimations1 = new ATMAnimations();
        ConvertCurrency convertCurrency1 = new ConvertCurrency();
        Surprise surprise1 = new Surprise();

        while (userMenuChoice != "8")
        {
            atmAnimations1.StartMessage();
            Console.WriteLine("\nPlease enter a menu choice: \n   1. Deposit Funds\n   2. Withdrawl Funds\n   3. Transfer Funds\n   4. Invest\n   5. Convert Currency\n   6. Quit\n   7. Wake up, Neo");
            userMenuChoice = Console.ReadLine();

            if (userMenuChoice == "1")
            {
                deposit1.OpeningMessage(transfer1.PassSavings(), transfer1.PassChecking());
                Console.WriteLine("Which account would you like to deposit funds into?: ");
                string routingChoice = Console.ReadLine();
                Console.WriteLine("What is the amount of funds to deposit?: ");
                double depositAmount = double.Parse(Console.ReadLine());
                deposit1.MoneyIn(routingChoice, depositAmount);
                deposit1.ClosingMessage(transfer1.PassSavings(), transfer1.PassChecking());
            }
            else if (userMenuChoice == "2")
            {
                withdraw1.OpeningMessage(transfer1.PassSavings(), transfer1.PassChecking());
                Console.WriteLine("Which account would you like to withdraw funds from?: ");
                string routingChoice = Console.ReadLine();
                Console.WriteLine("What is the amount of funds you are withdrawing?: ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                withdraw1.MoneyOut(routingChoice, withdrawAmount);
                withdraw1.ClosingMessage(transfer1.PassSavings(), transfer1.PassChecking());
            }
            else if (userMenuChoice == "3")
            {
                transfer1.OpeningMessage(transfer1.PassSavings(), transfer1.PassChecking());
                Console.WriteLine("Which account would you like to transfer funds from?: ");
                string routingChoice = Console.ReadLine();
                Console.WriteLine("What is the amount of funds to move?: ");
                double moveAmount = double.Parse(Console.ReadLine());
                transfer1.MoneyOut(routingChoice, moveAmount);
                if (routingChoice == "1")
                {
                    routingChoice = "2";
                }
                else if (routingChoice == "2")
                {
                    routingChoice = "1";
                }
                transfer1.MoneyIn(routingChoice, moveAmount);
                transfer1.MovingFundsAnimation(routingChoice);
                transfer1.ClosingMessage(transfer1.PassSavings(), transfer1.PassChecking());
            }
            else if (userMenuChoice == "4")
            {
                invest1.OpeningMessage(transfer1.PassSavings(), transfer1.PassChecking());
                Console.WriteLine("Welcome to the investment hub, a comlementary Matrix Bank service to all of our Members.\nSelect from the investment options below to begin securing a financially stable retirement: ");
                Console.WriteLine("\nMenu Options: \n   1. Cryptocurrency Investing\n   2. Expand Portfolio ");
                string investChoice = Console.ReadLine();
                if (investChoice == "1")
                {
                    invest1.InvestInCrypto(transfer1.PassSavings(), transfer1.PassChecking());
                    invest1.ClosingMessage(transfer1.PassSavings(), transfer1.PassChecking());
                }
                else if (investChoice == "2")
                {
                    invest1.ExpandPortfolio(transfer1.PassSavings(), transfer1.PassChecking());
                    invest1.ClosingMessage(transfer1.PassSavings(), transfer1.PassChecking());
                }
            }
            else if (userMenuChoice == "5")
            {
                convertCurrency1.OpeningMessage(transfer1.PassSavings(), transfer1.PassChecking());

            }
            else if (userMenuChoice == "6")
            {
                Console.WriteLine("Thank you for choosing Matrix Banking! Enjoy you day. \n");
                Thread.Sleep(1000);
                Console.WriteLine("Exiting the Matrix...");
                atmAnimations1.EndMessage();
                userMenuChoice = "8";
            }
        }
    }
}