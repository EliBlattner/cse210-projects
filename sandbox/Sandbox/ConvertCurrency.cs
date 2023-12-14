public class ConvertCurrency
{
    //Converts all currency stored in an account into another currency.
    public void OpeningMessage(double _savingsAccount, double _checkingAccount)
    {
        Console.Clear();
        Console.WriteLine("--- Convert Currency ---");
        Thread.Sleep(1000);
        Console.WriteLine($"\nYour current account balances are: \n\n   1. Savings - ${_savingsAccount}\n   2. Checking - ${_checkingAccount}");
        Thread.Sleep(1000);
    }

   //public double CurrencyConversion(double _savingsAccount, double _checkingAccount)
   //{
    
   //}
    
}