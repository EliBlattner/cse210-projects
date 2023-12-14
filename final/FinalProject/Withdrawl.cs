public class Withdraw : Transfer
{
    public override void OpeningMessage(double _savingsAccount, double _checkingAccount)
    {
        //Overrides opening message specifically for Withdrawl class.
        Console.Clear();
        Console.WriteLine("--- Withdraw Funds ---");
        Thread.Sleep(1000);
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }

    public override void ClosingMessage(double _savingsAccount, double _checkingAccount)
    {
        //Overrides closing message specifically for Withdrawl class
        Console.WriteLine("--- Thank you for choosing Matrix Bank --- \nWe pride ourselves in providing readily available money withdrawing to all our customers.");
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }
}