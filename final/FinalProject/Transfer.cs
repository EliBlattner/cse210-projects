using System.ComponentModel;
public class Transfer
{
    //These 2 instance fields are public so that they can be accessed from all places in this code.
    //The frequency of their use and relatively easy mutability makes me feel like this is alright for this case.
    public static double _savingsAccount;
    public static double _checkingAccount;
    public virtual void OpeningMessage(double _savingsAccount, double _checkingAccount)
    {
        Console.Clear();
        Console.WriteLine("--- Transfer Funds ---");
        Thread.Sleep(1000);
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }   
    public void MoneyIn(string account, double moneyAmount)
    {
        //this method is just doing math and moving money.
        if (account == "1")
        {
            _savingsAccount += moneyAmount;
        }
        else if (account == "2")
        {
            _checkingAccount += moneyAmount;
        }
    }

    public void MoneyOut(string account, double moneyAmount)
    {
        //this method is just doing math and moving money.
        if (account == "1")
        {
            _savingsAccount -= moneyAmount;
        }
        else if (account == "2")
        {
            _checkingAccount -= moneyAmount;
        }
    }

    public virtual void ClosingMessage(double _savingsAccount, double _checkingAccount)
    {
        //Displays closing message specific to Transfer parent class.
        Console.WriteLine("\n--- Thank you for choosing Matrix Bank ---");
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }

    public void MovingFundsAnimation(string account)
    {
        //Creates a cool sinewave-style wait timer while funds are being transferred.
        Console.WriteLine("Moving funds...\n");
        List<string> animationCharacters = new List<string>{"¯¯--__--¯¯", "¯--__--¯¯-", "--__--¯¯--", "-__--¯¯--_", "__--¯¯--__", "_--¯¯--__-", "--¯¯--__--", "-¯¯--__--¯"};
        foreach (string anim in animationCharacters)
        {
            Console.Write(anim);
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b\b\b\b\b\b");
        }
        if (account == "1")
        {
            account = "Savings Account";
        }
        else if (account == "2")
        {
            account = "Checking Account";
        }
        Console.WriteLine($"\nFunds successfully moved to {account} ");
        Thread.Sleep(1000);
    }
    
    public double PassSavings()
    {
        return _savingsAccount; 
    }

    public double PassChecking()
    {
        return _checkingAccount;
    }
}