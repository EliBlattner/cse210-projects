public class Deposit : Transfer
{
    public override void OpeningMessage(double _savingsAccount, double _checkingAccount)
    {
        //Overrides opening message for Deposit class.
        Console.Clear();
        Console.WriteLine("--- Deposit Funds ---");
        Thread.Sleep(1000);
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }

    public override void ClosingMessage(double _savingsAccount, double _checkingAccount)
    {
        //Overrides closing message for Deposit class.
        Console.WriteLine("--- Thank you for choosing Matrix Bank --- \nYou can rest assured knowing your deposits are always in good hands!");
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }
}