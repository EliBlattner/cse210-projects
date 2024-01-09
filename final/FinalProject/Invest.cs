using System.ComponentModel;
using System.ComponentModel.Design;
using System.Xml.Linq;

public class Invest : Transfer 
{
    private double _gainsOrLosses;
    private double investmentAccount;
    private double percentRate;
    private string routingChoice;


    public override void OpeningMessage(double _savingsAccount, double _checkingAccount)
    {
        Console.Clear();
        Console.WriteLine("--- Investment Hub ---");
        Thread.Sleep(1000);
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }
    public void InvestInCrypto(double _savingsAccount, double _checkingAccount)
    {
        Console.WriteLine("--- Invest In Cryptocurrency ---");
        Thread.Sleep(1000);
        Console.WriteLine("\nCryptocurrency investments offered: \n   1. Bitcoin  \n   2. Etherium  \n   3. DogeCoin  \n   4. None ");
        Console.WriteLine("\nWhich investment interests you?: ");
        Console.WriteLine($"\nYour current account balances are: \n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Console.WriteLine("Which account would you like to invest from?: ");
        routingChoice = Console.ReadLine();
        if (routingChoice == "1")
        {
            routingChoice = "Savings Account";
            investmentAccount = _savingsAccount;
        }
        else if (routingChoice == "2")
        {
            routingChoice = "Checking Account";
            investmentAccount = _checkingAccount;
        }
        Console.WriteLine($"What percent of your {routingChoice} would you like to invest into this cryptocurrency? ");
        percentRate = double.Parse(Console.ReadLine());
        _gainsOrLosses = investmentAccount - (investmentAccount * percentRate);
        Thread.Sleep(1000);
        Console.WriteLine($"${_gainsOrLosses} was removed from your account and invested in your cryptocurrency.");
        Console.WriteLine("...");
        double takeAway = _gainsOrLosses * 1.5;
        Thread.Sleep(1000);
        Console.WriteLine($"After a year, your ${_gainsOrLosses} grew by 150%!");
        Thread.Sleep(1000);
        investmentAccount += takeAway;

    }
    public void ExpandPortfolio(double _savingsAccount, double _checkingAccount)
    {
        Console.WriteLine("--- Expand Portfolio ---");
        Thread.Sleep(1000);
        Console.WriteLine("\nHere at Matrix Bank, we are incredibly proud to have a team of highly experienced and skilled investment managers. You can rest assured\nknowing that your finances are in good hands. Some of the stable and reputable businesses found in our investment packages include: ");
        Console.WriteLine("  [ BlockBuster Home Video ]  \n  [ Toys-R-Us ]  \n  [ Radio Shack ]  \n  [ Lehman Brothers Holdings ]");
        Thread.Sleep(1000);
        Console.WriteLine("\nWould you like to invest a portion of your assets into these companies? (y/n)");
        string askInvest = Console.ReadLine();
        if (askInvest == "y")
        {
            Console.WriteLine($"\nYour current account balances are: \n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
            Console.WriteLine("Which account would you like to invest from?: ");
            routingChoice = Console.ReadLine();
            if (routingChoice == "1")
            {
                routingChoice = "Savings Account";
                investmentAccount = _savingsAccount;
            }
            else if (routingChoice == "2")
            {
                routingChoice = "Checking Account";
                investmentAccount = _checkingAccount;
            }
            
            Console.WriteLine($"You have selected your {routingChoice}. What percentage would you like to invest? \n   a. [ 10% ]  \n   b. [ 25% ]  \n  c. [ 80% ]  \n  d. [ 0% ] ");
            string investmentBracket = Console.ReadLine();
            if (investmentBracket == "a")
            {
                percentRate = .10;
            }
            else if (investmentBracket == "b")
            {
                percentRate = .25;
            }
            else if (investmentBracket == "c")
            {
                percentRate = .80;
            }
            else if (investmentBracket == "d")
            {
                percentRate = 0;
            }
            double userBal = investmentAccount;
            investmentAccount = userBal - (userBal * percentRate);
            Thread.Sleep(1000);
            Console.WriteLine($"${userBal * percentRate} was removed from your account and moved into the investment folder.");
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine($"After a year, your ${userBal * percentRate} completely depreciated...That's too bad.\n\n");
            Thread.Sleep(5000);
        }
        else
        {
            Console.WriteLine("Returning to menu...");
            Thread.Sleep(1000);
        }
    }
    
    public override void ClosingMessage(double _savingsAccount, double _checkingAccount)
    {
        //Overrides specific for the Investing hub method.
        Console.WriteLine("--- Thank you for Investing with the Matrix Bank ---");
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }

    public void UpdateAccounts()
    {
        if (routingChoice == "1")
        {
            _savingsAccount = investmentAccount;
        }
        else if (routingChoice == "2")
        {
            _checkingAccount = investmentAccount;
        }  
    }
}