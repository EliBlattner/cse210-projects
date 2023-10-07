using System;
using System.Security.Cryptography.X509Certificates;

public class Write
{
    public string _userEntry;
    public DateTime _currentDateTime;
    public string _promptSelection;
    
    public string Display()
    {
        string _currentDateTimeStr = _currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        return ($"{_currentDateTimeStr} , {_promptSelection} , {_userEntry}");
    } 
   
}