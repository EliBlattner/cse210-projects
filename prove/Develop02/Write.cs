using System;
using System.Security.Cryptography.X509Certificates;

public class Write
{
    public string _userEntry;
    public DateTime _currentDateTime;
    public string _promptSelection;
    
    public void Display()
    {
        _currentDateTime.ToString("yyyy-MM-dd");
        Console.WriteLine($"{_currentDateTime} , {_promptSelection} , {_userEntry}");
    } 
   
}